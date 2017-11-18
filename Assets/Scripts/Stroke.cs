using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stroke {
    [SerializeField]
    public List<Vector3> pts;

	public Stroke(){
		pts = new List<Vector3> ();
	}
}
