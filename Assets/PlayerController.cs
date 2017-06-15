using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 5f;
	public float runSpeed = 10f;
	public GameObject bullet;

	private bool readyShoot;
	private Camera cam;

	// Use this for initialization
	void Start () {
		cam = Camera.main;	
		readyShoot = true;
	}
	
	// Update is called once per frame
	void Update () {
		Interact ();
	}

	void FixedUpdate(){
		Move ();
		Rotate ();
	}

	void Move(){
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		if (horizontal != 0 || vertical != 0) {
			if (Input.GetKey (KeyCode.LeftShift)) {
				this.transform.Translate (new Vector3(horizontal,vertical,0) * runSpeed * Time.deltaTime);
			}
			this.transform.Translate (new Vector3(horizontal,vertical,0) * speed * Time.deltaTime);
		}
	}

	void Rotate(){

		Vector3 direction = Input.mousePosition - Camera.main.WorldToScreenPoint (transform.position);
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
		angle -= 90;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);


	}

	void Interact(){
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			if (InteractAble()) {
				//Interaction
			} else if(readyShoot) {
				//Instantiate (bullet, this.gameObject.transform.position, Quaternion.identity);
				readyShoot = false;
				Invoke("ResetShoot",0.5f);
			}
		}
	}

	void ResetShoot(){
		readyShoot = true;
	}

	bool InteractAble(){


		return false;

	}

}
