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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
}
