using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public Vector3 userPosition;

	public PlayerActions paObject;
	// Use this for initialization
	void Start () {
        userPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public Vector3 getPlayerPosition()
    {
        return userPosition;
    }

}
