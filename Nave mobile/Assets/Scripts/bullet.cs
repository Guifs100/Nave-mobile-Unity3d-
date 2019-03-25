using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public int dano;
	public float speed;
	public float lifeTime;
	private Rigidbody2D tiro;
	public int tipoBuff;

	//fazer o tiro acertar enemy e player
	public string target;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, lifeTime);
	}
	
//	// Update is called once per frame
//	void Update () {
//		
//
//	}

	void FixedUpdate(){
		transform.position = new Vector2 (this.gameObject.transform.position.x, this.gameObject.transform.position.y + (speed * Time.deltaTime));
	}

	//fazia a nave morrer
	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == target) {
			//Destroy (col.gameObject);
			/* tiro rápido
			if(tipoBuff == 1){
				float contador = Time.time;
				while(Time.time <= contador + 3){
					shooter.fireRate = 0.1f;
				}
				shooter.fireRate = 0.5f;
				
			}
			//mais vida
			else if(tipoBuff == 2){
			}
			*/
			
			Destroy (this.gameObject);
		}
	}
	
}
