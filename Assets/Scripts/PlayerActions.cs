using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerActions : MonoBehaviour {
    public Player player;
    private SpaceController spaceController; //one item only need to change in class diagram

	// Use this for initialization
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

    public CelestialBodies informationAboutPlant()
    {
        Vector3 playerPosition = player.getPlayerPosition();
        List < CelestialBodies > celestialBodies = spaceController.getCelestialBodies();
        CelestialBodies plant = spaceController.searchMinimumDistance(celestialBodies, playerPosition);

        return plant;
    }

}
