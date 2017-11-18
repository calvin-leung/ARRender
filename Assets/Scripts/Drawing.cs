using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Drawing {
	[SerializeField]
    public List<Stroke> strokes;

	public Drawing(){
		strokes = new List<Stroke> ();
	}
}