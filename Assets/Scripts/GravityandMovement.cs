using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityandMovement : MonoBehaviour {
	private bool far=true;
	public Rigidbody rb;
	private GameObject gameo;
	public GameObject[] go;

	/*public GravityandMovement(){

	}*/

	public static void generalGravity(GameObject go1,GameObject go2){
		Rigidbody rb1=go1.GetComponent<Rigidbody> (),
				rb2=go2.GetComponent<Rigidbody> ();
		print ("position= "+go2.transform.position.x );
		//float dist = Vector3.Distance (gameo.transform.position, transform.position);
		float d = go2.transform.position.magnitude - go1.transform.position.magnitude;
		float dx = go2.transform.position.x - go1.transform.position.x;//d for distance
		float dy = go2.transform.position.y - go1.transform.position.y;
		float dz = go2.transform.position.z - go1.transform.position.z;
		float fx = 0, fy = 0, fz = 0;
		if(dx != 0) fx = 0.000067f*rb1.mass * rb2.mass*dx / Mathf.Abs(d*d*d);//f for force
		if(dy != 0) fy = 0.000067f*rb1.mass * rb2.mass*dy / Mathf.Abs(d*d*d);
		if(dz != 0) fz = 0.000067f*rb1.mass * rb2.mass*dz / Mathf.Abs(d*d*d);
		rb1.AddForce (new Vector3(fx,fy,fz));
		print ("d= "+new Vector3(dx,dy,dz)+"force : " + new Vector3(fx,fy,fz) );
		/*if (dist <= 500.0) {
			print ("the distance is: " + dist);
			moon moonrb= gameo.GetComponent <moon>();
			moonrb.rb.AddForce (new Vector3 (0,0,50));
		}*/
		
	}
	/*static void generalGravity(){
		if (gameo != null) {
			//float dist = Vector3.Distance (gameo.transform.position, transform.position);
			float dx = gameo.transform.position.x - transform.position.x;//d for distance
			float dy = gameo.transform.position.y - transform.position.y;
			float dz = gameo.transform.position.z - transform.position.z;
			float fx = 0, fy = 0, fz = 0;
			if(dx != 0) fx = (float)0.067*rb.mass * gameo.GetComponent<Sphare> ().rb.mass*dx / Mathf.Abs(dx*dx*dx);//f for force
			if(dy != 0) fy = (float)0.067*rb.mass * gameo.GetComponent<Sphare> ().rb.mass*dy / Mathf.Abs(dy*dy*dy);
			if(dz != 0) fz = (float)0.067*rb.mass * gameo.GetComponent<Sphare> ().rb.mass*dz / Mathf.Abs(dz*dz*dz);
			rb.AddForce (new Vector3(fx,fy,fz));
			print ("d= "+(dx+dy+dz)+"force z: " + fz );
			/*if (dist <= 500.0) {
				print ("the distance is: " + dist);
				moon moonrb= gameo.GetComponent <moon>();
				moonrb.rb.AddForce (new Vector3 (0,0,50));
			}
		}
	}*/


	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
		rb.mass = transform.localScale.magnitude * transform.localScale.magnitude;
		gameo = GameObject.Find ("Sphere");
	}
	//on collision stop that code (for optimisation)
	void OnCollisionEnter(Collision collisionInfo){
		far = false;
	}
	void OnCollisionExit(Collision collisionInfo){
		far = true;
	}
	// Update is called once per frame
	void Update () {
		/*if (gameo != null) {
			//float dist = Vector3.Distance (gameo.transform.position, transform.position);
			float dx = gameo.transform.position.x - transform.position.x;//d for distance
			float dy = gameo.transform.position.y - transform.position.y;
			float dz = gameo.transform.position.z - transform.position.z;
			float fx = 0, fy = 0, fz = 0;
			if(dx != 0) fx = (float)0.067*rb.mass * gameo.GetComponent<Sphare> ().rb.mass*dx / Mathf.Abs(dx*dx*dx);//f for force
			if(dy != 0) fy = (float)0.067*rb.mass * gameo.GetComponent<Sphare> ().rb.mass*dy / Mathf.Abs(dy*dy*dy);
			if(dz != 0) fz = (float)0.067*rb.mass * gameo.GetComponent<Sphare> ().rb.mass*dz / Mathf.Abs(dz*dz*dz);
			rb.AddForce (new Vector3(fx,fy,fz));
			print ("d= "+(dx+dy+dz)+"force z: " + fz );
			/*if (dist <= 500.0) {
				print ("the distance is: " + dist);
				moon moonrb= gameo.GetComponent <moon>();
				moonrb.rb.AddForce (new Vector3 (0,0,50));
			}
		}*/
	}






}
