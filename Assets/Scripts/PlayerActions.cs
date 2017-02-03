using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour {

	// Use this for initialization
	SpaceController space;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void watchTheories()
	{
		
	}

	void manipulatePlanets()
	{
		
	}

	void selectAtom(){
		
	}
	void changeGravity(double amount,CelestialBodies planet){
		space.changeGravity(amount,planet.name);
	}

}
