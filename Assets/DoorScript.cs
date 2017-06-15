using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){
		RaycastHit2D hit = Physics2D.Raycast (transform.position, -Vector2.up, 15f);
		if (hit.collider != null) {
			Open ();
		}


	}

	void Open(){
		Destroy (this.gameObject);
	}
}
