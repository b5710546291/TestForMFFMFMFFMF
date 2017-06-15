using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueObjective : Objective {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void doAction ()
	{
		Debug.Log ("Rescue Subject!!");
		Destroy (this.gameObject);
	}

}
