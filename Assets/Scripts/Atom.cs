using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom : MonoBehaviour {
	public Electrone[] electrones;
	//private ArrayList <Electrone> electrones;
	private Nucleus nucleus;

	/*public Atom(){
		electrones = new ArrayList ();
	}
	public Atom(int numOfProtones,int numOfNeutrones, int numOfElectrones){
		nucleus = new Nucleus (numOfProtones, numOfNeutrones);
		electrones = new ArrayList (electrones);
		
	}
*/
	// Use this for initialization
	void Start () {//this a way of putting the electrones to scene but it gives warning so I not gonna do it for nucleus too till we know better method.
		for (int i = 0; i < electrones.Length; i++) {
			electrones [i] = new Electrone (new Vector3(i*2,0,0));
			Instantiate(electrones [i]);
			//electrones [i].putElectroneInScene ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
