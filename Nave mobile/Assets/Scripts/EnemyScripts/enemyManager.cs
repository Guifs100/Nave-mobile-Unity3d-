using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour {

	//public player playerHealth;
	//public PlayerHealth playerHealth;     // Reference to the player's heatlh.
	public GameObject enemy;                // The enemy prefab to be spawned.
	public GameObject comet;
	public GameObject mestre;
	//public GameObject buffTiro;
	//public GameObject buffLife;	
	public static bool deadBoss = true;
	public float spawnTime;		            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.


	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		InvokeRepeating ("SpawnComet", spawnTime, spawnTime);
		//InvokeRepeating ("SpawnTiro", spawnTime, spawnTime * 5);
		//InvokeRepeating ("SpawnLifeUp", spawnTime * 2, spawnTime * 10);
	}

	void Update() {
		if (deadBoss){
			deadBoss= false;
			Invoke ("SpawnBoss", spawnTime * 3);
		}	
	}

	void Spawn ()
	{
		// If the player has no health left...
		if(player.life <= 0)
		{
			// ... exit the function.
			return;
		}

		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}

	void SpawnComet(){
		// If the player has no health left...
		if(player.life <= 0)
		{
			// ... exit the function.
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		// Find a random index between zero and one less than the number of spawn points.
		Instantiate (comet, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);


		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		
	}

	void SpawnBoss ()
	{
		// If the player has no health left...
		if(player.life <= 0)
		{
			// ... exit the function.
			return;
		}
		else{

			// Find a random index between zero and one less than the number of spawn points.
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
			Instantiate (mestre, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		}
	}
	/*
	void SpawnTiro(){
		// If the player has no health left...
		if(player.life <= 0)
		{
			// ... exit the function.
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Find a random index between zero and one less than the number of spawn points.
		Instantiate (buffTiro, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	
		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		
	}

	void SpawnLifeUp(){
		// If the player has no health left...
		if(player.life <= 0)
		{
			// ... exit the function.
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		// Find a random index between zero and one less than the number of spawn points.
		Instantiate (buffLife, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		
	}
	*/

}
