using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class shooter : MonoBehaviour {

	public GameObject bullet;
	public Transform bulletSpawn;
	public static float fireRate = 0.5f;

	private float nextShoot;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
//		if(Input.GetKeyDown("space") && Time.time > nextShoot){
//			nextShoot = Time.time + fireRate;
//			Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
//
//		}
		if(CrossPlatformInputManager.GetButtonDown ("Fire"))
			Shooter ();
	}

	public void Shooter(){
		if (Input.GetKeyDown ("space") && Time.time > nextShoot) {
			nextShoot = Time.time + fireRate;
			Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
		}

			if(Time.time > nextShoot){
				nextShoot = Time.time + fireRate;
				Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
		}
	}
}
