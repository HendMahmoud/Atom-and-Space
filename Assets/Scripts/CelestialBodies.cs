using UnityEngine;
using System.Collections;

public class CelestialBodies : MonoBehaviour {

   private string name;
    private Vector3 scale;
    private float speed;
    private float distanceFromCenter;
    private Vector3 center;
    private string type;
    private CelestialBodies rotateAround;
    public Vector3 position; //add this to class diagram
    public float gravity;
    private PlanetInfo info;
    //public GameObject _object;
	// Use this for initialization
	void Start () {
        scale = this.transform.localScale;
        position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void setType(string _type)
    {
        type = _type;
    }
    public string getType()
    {
        return type;
    }
    public Vector3 getPosition()
    {
        return position;
    } 
    public void setGravity(float _gravity)
    {
        gravity = _gravity;
    } 
    public float getGravity()
    {
        return gravity;
    }
    public void setName(string _name)
    {
        name = _name;
    }
    public string getName()
    {
        return name;
    }
    public void setInfo(PlanetInfo _info)
    {
        info = _info;
    }
    public PlanetInfo getInfo()
    {
        return info;
    }
   
   
}
