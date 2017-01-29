using UnityEngine;
using System.Collections;

public class SpaceController : MonoBehaviour {
	Sun sun;
	Planet[] planets ;

	SpaceController(Sun sun, Planet planet)
	{
		this.sun = sun; 
		this.planets = planet;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
