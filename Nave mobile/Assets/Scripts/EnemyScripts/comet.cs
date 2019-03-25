using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comet : MonoBehaviour
{
    public float speed ;
    public int life;
    public int scoreEnemy;
    public string target;
    public string bullet;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		Destroy(this.gameObject, 4.0f);
	}

    // Update is called once per frame
    void Update()
    {
		if (player.life <= 0){
            Destroy (this.gameObject);
            enemyManager.deadBoss = true;
        }
        transform.position = new Vector2 (this.gameObject.transform.position.x, 
                            this.gameObject.transform.position.y + (speed * Time.deltaTime));
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
