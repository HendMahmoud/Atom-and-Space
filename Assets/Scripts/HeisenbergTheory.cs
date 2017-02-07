using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeisenbergTheory : AtomTheories {	

	public GameObject[] electrones;
	public GameObject[] brotones;
	public GameObject[] netrones;
	private Rigidbody rb;
	public Vector3 position;

	// Use this for initialization
	void Start () {//this a way of putting the electrones to scene but it gives warning so I not gonna do it for nucleus too till we know better method.
		rb = GetComponent <Rigidbody> ();
		createNucles(position);
		//createParticle(brotones,position);
		print(netrones [0].transform.position);
		netrones [0].transform.position = new Vector3(0,0,0);
		//netrones[0].
		//createParticle(electrones,position);
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=1;i<netrones.Length;i++){
			GravityandMovement.generalGravity(netrones[i],netrones[0]);
		}
		for(int i=0;i<brotones.Length;i++){
			GravityandMovement.generalGravity(brotones[i],netrones[0]);
		}
	}


	/*void createParticle(GameObject[] go,Vector3 pos){
		//int N = netrones.Length + brotones.Length;
		float r = (float)1.0*go [0].transform.localScale.x;
		print (r);
		float x = 0, y = 0, z = 0, theta = 0;
		for (int i = 0; i < go.Length; i++) {
			z = Random.Range (-1 * r, r);
			theta = Random.Range ((float)0.0, (float)3.14159*2);
			x = Mathf.Sqrt (r * r - z * z) * Mathf.Cos (theta);
			y = Mathf.Sqrt (r * r - z * z) * Mathf.Sin (theta);
			print (" x= " + x + " y= " + y + " z= " + z);
			Instantiate(go [i],new Vector3(pos.x+x,pos.y+y,pos.z+z),Quaternion.identity);
			//electrones [i].putElectroneInScene ();
		}
	
		
	}*/
		public void createNucles(Vector3 pos){
		int n = netrones.Length + brotones.Length;
		/*GameObject[] nucleus = new GameObject[n];
		for (int i = 0; i < netrones.Length; i++) {
			nucleus[i]=netrones [i];
		}
		for (int i = 0; i < brotones.Length; i++) {
			nucleus [i + netrones.Length] = brotones [i];
		}*/
		float inc = Mathf.PI * (3 - Mathf.Sqrt(5));
		float off = 2.0f / n;
		float x = 0;
		float y = 0;
		float z = 0;
		float r = 0;
		float phi = 0;

		for (var k = 0; k < netrones.Length; k++){
			y = k * off - 1 + (off /2);
			r = Mathf.Sqrt(1 - y * y)+200;
			phi = k * inc;
			x = Mathf.Cos(phi) * r;
			z = Mathf.Sin(phi) * r;
			netrones [k]=Instantiate(netrones [k],new Vector3(pos.x+x,pos.y+y,pos.z+z),Quaternion.identity);
			print (netrones [k].transform.position);
			//upts.Add(new Vector3(x, y, z));
		}
		for (var k = netrones.Length; k < n; k++){
			y = k * off - 1 + (off /2);
			r = Mathf.Sqrt(1 - y * y)+200;
			phi = k * inc;
			x = Mathf.Cos(phi) * r;
			z = Mathf.Sin(phi) * r;
			brotones [k-netrones.Length]=Instantiate(brotones [k-netrones.Length],new Vector3(pos.x+x,pos.y+y,pos.z+z),Quaternion.identity);
			//upts.Add(new Vector3(x, y, z));
		}
		/*
		float r = netrones [0].transform.localScale.x;
		int n = 0,malfa;
		print ("r= " + r);
		float x,y,z,a=4*Mathf.PI*Mathf.Pow(r,2.0f)/(N);
		float d = Mathf.Sqrt (a);
		print("a= "+a+" d= "+d);
		int m = (int)Mathf.Round (Mathf.PI*100 / d);
		float dtheta = Mathf.PI / m, dalfa = a / dtheta;
		float theta = 0,alfa;
		print (m + " ");
		for (int i = 0; i < m; i++) {
			theta = (Mathf.PI * i + 0.5f) / m;
			malfa = (int)Mathf.Round (2 * Mathf.PI * Mathf.Sin (theta) / dalfa);
			for (int j = 0; j < malfa; j++) {
				alfa = 2 * Mathf.PI * j / malfa;
				x = r * Mathf.Sin (theta) * Mathf.Cos (alfa);
				y = r * Mathf.Sin (theta) * Mathf.Sin (alfa);
				z = r * Mathf.Cos (theta);
				print (x + " " + y + " " + z);
				Instantiate(nucleus [i],new Vector3(pos.x+x,pos.y+y,pos.z+z),Quaternion.identity);
			}
		}*/
	}


	/*public Particle[] electrones;
	//private ArrayList <Electrone> electrones;
	private Particle[] brotones;
	private Particle[] netrones;*/
	/*public Atom(){
		electrones = new ArrayList ();
	}
	public Atom(int numOfProtones,int numOfNeutrones, int numOfElectrones){
		nucleus = new Nucleus (numOfProtones, numOfNeutrones);
		electrones = new ArrayList (electrones);
		
	}
/*for (int i = 1; i <= brotones.Length; i++) {
			brotones [i] = new Particle (new Vector3(i*2,0,0));
			Instantiate(brotones [i]);
			//electrones [i].putElectroneInScene ();
		}
		for (int i = 1; i <= netrones.Length; i++) {
			netrones [i] = new Particle (new Vector3(i*2,0,0));
			Instantiate(netrones [i]);
			//electrones [i].putElectroneInScene ();
		}
		for (int i = 1; i <= electrones.Length; i++) {
			electrones [i] = new Particle (new Vector3(i*2,0,0));
			Instantiate(electrones [i]);
			//electrones [i].putElectroneInScene ();
		}*/
//*/
}
