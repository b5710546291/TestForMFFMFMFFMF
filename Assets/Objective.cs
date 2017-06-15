using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Objective : MonoBehaviour {
	public GameObject player;
	public string objtName{ get; set;}
	public string status{ get; set;}
	public string description{ get; set;}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

	void OnMouseDown(){
		if (Vector2.Distance (player.transform.position, this.transform.position) <= 0.5f) {
			doAction ();
		}
	}

	public abstract void doAction ();
		
}
