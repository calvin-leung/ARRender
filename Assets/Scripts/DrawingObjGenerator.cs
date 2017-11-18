using UnityEngine;
using System.Text.RegularExpressions;

public class DrawingObjGenerator : MonoBehaviour{
	public GameObject drawingObjPrefab;
	public GameObject strokeObjPrefab;

	// Generates a GameObject from a Drawing and returns it
	public GameObject genObject(Drawing drawing){
		Transform parentTransform = Instantiate (drawingObjPrefab).transform;
		foreach(var stroke in drawing.strokes){
			StrokeObj strokeObj = Instantiate (strokeObjPrefab, parentTransform).GetComponent<StrokeObj>();
			strokeObj.updateRender (stroke);
		}

		// Attach and initilize Kudan Drivers/Markers here

		return parentTransform.gameObject;
	}

	public GameObject genObject(Graffiti graffiti){
		return genObject (graffiti.drawing);
	}

	public Drawing genDrawing(string importString){
		// Put names of fields between quotes
		Regex re = new Regex ("([A-Za-z_]+[A-Za-z_0-9]*)\\s*=");
		importString = re.Replace(importString, "\"$1\"=");
		// Replace '=' with ':'
		re = new Regex ("=");
		importString = re.Replace(importString, ":");
		return JsonUtility.FromJson<Drawing> (importString);
	}
}
