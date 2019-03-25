using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public Transform posPlayer;
	public int life;
	public float speed;
	public string target;
	public string bullet;
	public int scoreEnemy;
	private float distancia;
	public float distMax;

	// Use this for initialization
	void Start () {
		//destroy o inimigo se não colidir com nada
		Destroy(this.gameObject, 4.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (player.life <= 0){
            Destroy (this.gameObject);
            enemyManager.deadBoss = true;
        }
		posPlayer.position = GameObject.FindGameObjectWithTag("Player").transform.position;
//		dessa forma o inimigo para no meio. Utilizar em inimigos que atira no adversário
//		transform.position = new Vector2 (this.gameObject.transform.position.x, 
//										  this.gameObject.transform.position.y + (speed * this.gameObject.transform.position.y * Time.deltaTime));
		//Debug.Log(posPlayer.position);
		//pega a disctancia do player e inimigo
		distancia = Vector2.Distance(transform.position, posPlayer.position);
		if(distancia >= distMax){	
			//Vector2.MoveTowards (<pos enemy>, pos player, velocidade)		para perseguir o player
			this.transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, speed * Time.deltaTime);
		}
		else{
			 transform.position = new Vector2 (this.gameObject.transform.position.x, 
										  this.gameObject.transform.position.y + ((speed * -1) * Time.deltaTime));
		
		}
	}
	

	void OnTriggerEnter2D (Collider2D col){
		//eh destruida se nave inimigo se encostar nas balas do player
		if(col.gameObject.tag == bullet){
			life --;
			if(life <= 0){
				player.count += this.scoreEnemy;
				Destroy (this.gameObject);
			}
		}

		//destroi inimigo depois de um tempo
		//if()
		//destroi a nave do player se enconstar no mesmo
		if(col.gameObject.tag == target){
			//Debug.Log (player.life);
			player.life--;
			//Debug.Log (player.life);
			Destroy(this.gameObject);
			/* 
			if (player.life <= 0) {
				Destroy (col.gameObject);
			}
			*/
		}
	}

}
