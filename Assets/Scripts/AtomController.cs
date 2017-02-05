using UnityEngine;
using System.Collections;

public class AtomController : MonoBehaviour {
	AtomTheories theory;
	int years;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void watchTheories()
	{
		if (years >= 1927) 
		{
			theory = new HeisenbergTheory ();
		}
		else if (years >= 1926)
		{
			theory = new SchrodingerAtom ();

		}
		else if(years >= 1913)
		{
			theory = new RutherFordTheory ();
		}
		else
		{
			theory = new BohrTheory ();
		}
		theory.move ();
	}

	void makeChemicalReaction()
	{
	}
	void viewAtom()
	{
				
	}
}
