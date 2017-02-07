using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : ScriptableObject {
	GameObject sphere;
	// Use this for initialization
	public Particle (Vector3 pos) {
		sphere = GameObject.CreatePrimitive (PrimitiveType.Plane);
		sphere.transform.position = pos;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
