using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class StrokeObj : MonoBehaviour {
	private LineRenderer lineRend;

	void Awake(){
		lineRend = GetComponent<LineRenderer> ();
	}

	public void updateRender(Stroke s){
		if(s == null || s.pts.Count <= 0){ return; }

		lineRend.positionCount = s.pts.Count;
		lineRend.SetPositions (s.pts.ToArray());
	}
}
