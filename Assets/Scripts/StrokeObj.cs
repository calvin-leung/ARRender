using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class StrokeObj : MonoBehaviour {
	private LineRenderer lineRend;

	void Awake(){
		
	}

	public void updateRender(Stroke s){
		if(s == null || s.pts.Count <= 0){ return; }
		if(lineRend == null){
			lineRend = GetComponent<LineRenderer> ();
		}

		lineRend.positionCount = s.pts.Count;
		lineRend.SetPositions (s.pts.ToArray());
		lineRend.startColor = s.color;
		lineRend.endColor = s.color;
	}
}
