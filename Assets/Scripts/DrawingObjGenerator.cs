﻿using UnityEngine;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class DrawingObjGenerator : MonoBehaviour{
	public GameObject drawingObjPrefab;
	public GameObject strokeObjPrefab;
	public Transform parentObject;

	public GameObject genObject(List<Stroke> strokes) {				// Generates a GameObject from a Drawing and returns it
		Transform parentTransform = Instantiate (drawingObjPrefab, parentObject).transform;
		foreach(var stroke in strokes){
			StrokeObj strokeObj = Instantiate (strokeObjPrefab, parentTransform).GetComponent<StrokeObj>();
			strokeObj.updateRender (stroke);
		}

		return parentTransform.gameObject;
	}

	public GameObject genObject(Graffiti graffiti){
		return genObject (graffiti.strokes);
	}

	public Drawing genDrawing(string importString){
		Regex re = new Regex ("([A-Za-z_]+[A-Za-z_0-9]*)\\s*=");
		importString = re.Replace(importString, "\"$1\"="); 		// Put names of fields between quotes
		re = new Regex ("=");
		importString = re.Replace(importString, ":");				// Replace '=' with ':'
		return JsonUtility.FromJson<Drawing> (importString);
	}
}
