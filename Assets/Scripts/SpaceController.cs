
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System;

public class SpaceController : MonoBehaviour {
    
     List<CelestialBodies> celestialBodies;
    // GameObject[] _objects;
    void Start()
    {
        string[] lines = System.IO.File.ReadAllLines(@"planetsInfo.txt");
  
        celestialBodies = new List<CelestialBodies>();
        
        for (int i = 0; i < lines.Length; i++)
        {
            
           CelestialBodies c = GameObject.Find(lines[i]).GetComponent<CelestialBodies>(); //find all planet objects by their names
            
            PlanetInfo info = new PlanetInfo();
                c.setName(lines[i]);
                c.setType("Planet");

                i++;
                string[] words = lines[i].Split(' '); 
                float volume = float.Parse(words[1], CultureInfo.InvariantCulture.NumberFormat);
                info.setVolume(volume);
                //--------------------------------------------------------------
                i++;
                words = lines[i].Split(' ');
                float radius = float.Parse(words[1], CultureInfo.InvariantCulture.NumberFormat);
                info.setRadius(radius);
                //----------------------------------------------------------------
                i++;
                words = lines[i].Split(' ');
                float circumference = float.Parse(words[1], CultureInfo.InvariantCulture.NumberFormat);
                info.setCircumference(circumference);
                //-------------------------------------------------------------
                i++;
                words = lines[i].Split(' ');
                float mass = float.Parse(words[1], CultureInfo.InvariantCulture.NumberFormat);
                info.setMass(mass);
                //----------------------------------------------------------------
                i++;
                words = lines[i].Split('*');
                info.setSurface(words[1]);
                //---------------------------------------------------------------------
                i++;
                words = lines[i].Split(' ');
                float avergTemperature = float.Parse(words[1], CultureInfo.InvariantCulture.NumberFormat);
                info.setAverageTemperature(avergTemperature);
                //--------------------------------------------------------------------
                i++;
                words = lines[i].Split('*');
                info.setPositionFromSun(words[1]);
                //--------------------------------------------------------------------------
                i++;
                words = lines[i].Split(' ');
                int orbitalPeriod = Convert.ToInt32(words[1]);
                info.setOrbitalPeriod(orbitalPeriod);
              //  print(words[1]);
                //------------------------------------------------------------------------------
                i++;
                words = lines[i].Split('*');
                info.setDayHours(words[1]);
                //---------------------------------------------------------------------------
                i++;
                words = lines[i].Split(' ');
                int numberOfMoons = Convert.ToInt32(words[1]);
                info.setNumberOfMoons(numberOfMoons);
                //print(words[1]);
                //--------------------------------------------------------------------------
                i++;
                //lightspeed
                //---------------------------------------------------------------------------
                i++;
                words = lines[i].Split(' ');
                float gravity = float.Parse(words[1], CultureInfo.InvariantCulture.NumberFormat);
                c.setGravity(gravity);
                //------------------------------------------------------------------------------
                i++;
                words = lines[i].Split(' ');
                float distanceFromSun = float.Parse(words[1], CultureInfo.InvariantCulture.NumberFormat);
                info.setDistanceFromSun(distanceFromSun);
                //---------------------------------------------------------------------
                i++;
                c.setInfo(info);
            celestialBodies.Add(c);
            }
       // foreach (CelestialBodies c in celestialBodies) print(c.ToString());
    }
    


    // Update is called once per frame
    void Update()
    { 

    }

    SpaceController(List<CelestialBodies> bodies)
    {
        celestialBodies = new List<CelestialBodies>();
        this.celestialBodies = bodies;

    }
  
    CelestialBodies search (string planetName) {
        //CelestialBodies planet = celestialBodies. Where (x => x.name == planetName); 
        //return planet;
        return null;

	}
	public void changeGravity (string planetName, float amount){
		CelestialBodies planet = search (planetName);  
		planet.setGravity (amount);
	}
	

    public List<CelestialBodies> getCelestialBodies()
    {
        return celestialBodies;
    }
    public CelestialBodies searchMinimumDistance(List<CelestialBodies> cel,Vector3 playerPosition)
    {
        
        CelestialBodies plant = new CelestialBodies();
        float minDistance=0 ;
        bool flag = false;
      
        foreach(CelestialBodies c in cel)
        {
            
            if(c.getType().ToLower().Equals("planet")&&!flag) //to make sure that the first minDisance is of the first plant in the array
            {
                Vector3 plantPosition = c.getPosition();
                Vector3 cal = new Vector3(playerPosition.x - plantPosition.x, playerPosition.y - plantPosition.y, playerPosition.z - plantPosition.z);
                minDistance =  Mathf.Sqrt(cal.x * cal.x + cal.y * cal.y + cal.z * cal.z);
                plant = c;
                flag = true; 
            } 
            else if(c.getType().ToLower().Equals("planet") )
            {
                Vector3 plantPosition = c.getPosition();
                Vector3 cal = new Vector3(playerPosition.x - plantPosition.x, playerPosition.y - plantPosition.y, playerPosition.z - plantPosition.z);
                float distance = Mathf.Sqrt(cal.x * cal.x + cal.y * cal.y + cal.z * cal.z);
            
                if (distance<minDistance)
                {
                    minDistance = distance;
                    plant = c;
                }
            } 
        }
        return plant;
    }
}
