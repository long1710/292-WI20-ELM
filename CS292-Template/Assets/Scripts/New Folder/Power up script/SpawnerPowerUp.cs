using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPowerUp : MonoBehaviour
{
    public Transform[] SpawnPoint;
    public GameObject[] projectile;
    public GameObject Panel;
    public GameObject IconCoffee;
    public GameObject IconMonster;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    
    public float minTimeBetweenSpawns;
    public float decrease;

    private float maxDistance;
    private float minDistance; 
    private Vector3 spawn; 
    // Start is called before the first frame update

    GameObject[] spawnlings = new GameObject[1];
    void Start()
    {
        maxDistance = 1708;
        minDistance = -1789;

    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwSpawns <= 0 && !IconCoffee.activeSelf && !IconMonster.activeSelf){ // so that no more power up spawn, temporary
            //if(spawnlings[0] == null){
                //Transform randomSpawnPoint = SpawnPoint[Random.Range(0, SpawnPoint.Length)];
                GameObject randomProjectile = projectile[Random.Range(0, projectile.Length)];
                //note: can't work on position for now: work on homing position instead
                spawn = new Vector3(Random.Range(minDistance, maxDistance), -900, 0);
                GameObject spawnling = Instantiate(randomProjectile, spawn, Quaternion.identity) as GameObject;
                //spawnlings[0] = spawnling;
                spawnling.transform.SetParent(Panel.transform, false);
                
                if(startTimeBtwSpawns > minTimeBetweenSpawns){
                    startTimeBtwSpawns -= decrease;
                }
                timeBtwSpawns = startTimeBtwSpawns;
            //}
        }
        else {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
