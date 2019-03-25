using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScript : MonoBehaviour {

	//public GameObject menu;			//botão menu
	//public GameObject retry;		//botão retry
	public GameObject panel;		//painel de botões

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.life <= 0){
			//menu.SetActive (true);
			//retry.SetActive (true);
			panel.SetActive (true);
		}
	}

	public void ChangeScene (string sceneName)
	{
		SceneManager.LoadScene (sceneName);
		player.life = 3;
		player.count = 0;
		enemyManager.deadBoss = true;
	}
}
