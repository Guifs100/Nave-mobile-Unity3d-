using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;							//Biblioteca para manipular o GUI
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour {
	
	//public float speed;
	public static int life = 3;
	public static int count = 0; 	//Contador do Score
	public Text scorePlayer;		//Texto do Score
	public Text lifePlayer;			//texto de vida
	//valor do math clamp para limite da nave
	public float lim;

	public float moveSpeed;
	float directionX;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log(Time.time);
	}

	void FixedUpdate(){
//		faz com Que vai e volte o GO
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//		transform.position = new Vector2(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime);

//		faxer o tiro
		//		if(Input.GetKeyDown("space") && Time.time > ){
		//
		//
		//		} 


		Movimento ();
		SetScore ();
		SetLife();
		Lose();
	}

	void Movimento(){
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		if(moveHorizontal != 0){
//			transform.position = new Vector2( this.gameObject.transform.position.x +  (moveHorizontal * speed * Time.deltaTime), this.gameObject.transform.position.y);	
//		}

		directionX = CrossPlatformInputManager.GetAxis ("Horizontal") * moveSpeed;
		rb.velocity = new Vector2 ( directionX, rb.velocity.y);
		//mathf.Clamp limita a distância em que a nace irá percorrer no eixo x
		this.gameObject.transform.position = new Vector3(Mathf.Clamp(transform.position.x, lim * -1,lim), transform.position.y, transform.position.z);
		
	}

	void OnTriggerEnter2D (Collider2D col){
		//eh destruida se nave inimigo se encostar nas balas do player
		if(col.gameObject.tag == "BulletBoss"){
            life --;
		}
	}

	//função que pega a pontuação e atualiza em texto no UI ou GUI
	void SetScore(){
		scorePlayer.text = "Score: " + count.ToString();
	}

	void SetLife(){
		lifePlayer.text = "HP: " + life.ToString();
	}

	void Lose(){
		if (life <= 0) {
			Destroy (this.gameObject);
		}
	}
}
