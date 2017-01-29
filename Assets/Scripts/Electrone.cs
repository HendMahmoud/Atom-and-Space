using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electrone : ScriptableObject {
	GameObject sphere;
	// Use this for initialization
	public Electrone (Vector3 pos) {
		sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphere.transform.position = pos;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
