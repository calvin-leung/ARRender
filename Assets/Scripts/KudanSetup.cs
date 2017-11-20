using UnityEngine;

namespace Kudan.AR{
	public class KudanSetup : MonoBehaviour {
		public KudanTracker kudanTracker;

		void Start(){
			Invoke ("toggleTracking", 1);	// Kudan needs some setup time before you can start tracking (> 0.5s)
		}

		public void toggleTracking(){
			if(!kudanTracker.ArbiTrackIsTracking ()){
				Vector3 floorPosition;			// The current position in 3D space of the floor
				Quaternion floorOrientation;	// The current orientation of the floor in 3D space, relative to the device

				kudanTracker.FloorPlaceGetPose (out floorPosition, out floorOrientation);	// Gets the position and orientation of the floor and assigns the referenced Vector3 and Quaternion those values
				kudanTracker.ArbiTrackStart (floorPosition, floorOrientation);				// Starts markerless tracking based upon the given floor position and orientations
			}else{
				kudanTracker.ArbiTrackStop ();
			}
		}
	}
}