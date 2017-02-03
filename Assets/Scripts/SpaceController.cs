using UnityEngine;
using system.Collections;
using system.Collections. Generic; 
using system.Linq; 
public class SpaceController : MonoBehaviour {
List<CelestialBodies> celestialBodies ;

	SpaceController (CelestialBodies bodies ){	
		this. celestialBodies = bodies;
	}
	//Use this for initialization
	CelestialBodies search (string planetName) {
	 	CelestialBodies planet = celestialBodies. Where (x => x.name == planetName); 
 		return planet;
	}
	void changeGravity (string planetName, double amount){
		Celestial Bodies planet = search (planetName);  
		planet.setGravity (amount);
	}
	void start () {

	}
	// Update is called once per frame
	void Update () {
	}
}
