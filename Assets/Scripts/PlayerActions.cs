using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerActions : MonoBehaviour {
    public Player player;
    public SpaceController spaceController; //one item only need to change in class diagram

	// Use this for initialization
	SpaceController space;
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
      //  CelestialBodies c = informationAboutPlant();

    }

    void watchTheories()
	{
		
	}

	void manipulatePlanets()
	{
		
	}

	void selectAtom(){
		
	}
	void changeGravity(float amount,CelestialBodies planet){
		space.changeGravity(planet.name,amount);
	}

    public void informationAboutPlant()
    {
        Vector3 playerPosition = player.getPlayerPosition();
        print(playerPosition);
        List < CelestialBodies > celestialBodies = spaceController.getCelestialBodies();
        CelestialBodies planet = spaceController.searchMinimumDistance(celestialBodies, playerPosition);
        string info =planet.getName()+"\n"+"Volume " +planet.getInfo().getVolume() + "\nCircumference "+ planet.getInfo().getCircumference()+"\n"+"Mass"+planet.getInfo().getMass()+
            "Radius "+planet.getInfo().getRadius()+"\n"+"Surgace "+planet.getInfo().getSurface()+"\n"+
            "Average Temperature "+planet.getInfo().getAverageTemperature()+"\n"+"Position from sun "+planet.getInfo().getPositionFromSun()+
            "\n"+ "Orbital Period "+planet.getInfo().getOrbitalPeroid()+"\n"+ "NumberOfHoursInOneDay "+planet.getInfo().getDayHours()+"\n"+
            "number Of Moons "+planet.getInfo().getNumberOfMoons()+"\n"+ "Gravity Amount "+planet.getGravity()+
            "\n"+ "Distance from Sun "+planet.getInfo().getDistanceFromSun();
        TextMesh textObject = GameObject.Find("PlanetInfo").GetComponent<TextMesh>();
        textObject.text = info;


        //  return plant;
    }

}
