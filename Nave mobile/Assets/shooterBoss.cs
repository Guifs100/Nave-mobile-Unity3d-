using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterBoss : MonoBehaviour
{
    private float InstantiationTimer = 2f;
    public GameObject bullet;
	public Transform bulletSpawn;

    void Update () {
         CreatePrefab();
    }
 
    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            InstantiationTimer = 2f;
            //Debug.Log("foi tiro boss");
        }
    }
}
