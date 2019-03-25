using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public void ChangeScene (string sceneName){
		SceneManager.LoadScene (sceneName);
		player.life = 3;
		player.count = 0;
		enemyManager.deadBoss = true;
	}
}
