using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceController : MonoBehaviour {
    
    List<CelestialBodies> celestialBodies;
    
    SpaceController()
	{
        celestialBodies = new List<CelestialBodies>();	
        //here we have to add all plants and their information
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public List<CelestialBodies> getCelestialBodies()
    {
        return celestialBodies;
    }
    public CelestialBodies searchMinimumDistance(List<CelestialBodies> cel,Vector3 playerPosition)
    {
        CelestialBodies plant = new CelestialBodies();
        //for(int i=0;i<cel.Count ;i++)
        //{

        //}
        float minDistance=0 ;
        bool flag = false;
        foreach(CelestialBodies c in cel)
        {
            if(c.getType().ToLower().Equals("plant")&&!flag) //to make sure that the first minDisance is of the first plant in the array
            {
                Vector3 plantPosition = c.getPosition();
                Vector3 cal = new Vector3(playerPosition.x - plantPosition.x, playerPosition.y - plantPosition.y, playerPosition.z - plantPosition.z);
                minDistance =  Mathf.Sqrt(cal.x * cal.x + cal.y * cal.y + cal.z * cal.z);
                plant = c;
                flag = true; 
            } 
            else if(c.getType().ToLower().Equals("plant") )
            {
                Vector3 plantPosition = c.getPosition();
                Vector3 cal = new Vector3(playerPosition.x - plantPosition.x, playerPosition.y - plantPosition.y, playerPosition.z - plantPosition.z);
                float distance = Mathf.Sqrt(cal.x * cal.x + cal.y * cal.y + cal.z * cal.z);
                if(distance<minDistance)
                {
                    minDistance = distance;
                    plant = c;
                }
            } 
        }
        return plant;
    }
}
