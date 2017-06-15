using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject target;
	public float distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position =new Vector3 (target.transform.position.x,
			target.transform.position.y,
			target.transform.position.z - distance);
	}
}
