using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObjective : Objective {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void doAction ()
	{
		Debug.Log("Key Pickup!!");
		Destroy (this.gameObject);
		this.status = "Done";
	}
}
