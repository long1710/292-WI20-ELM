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

    }

    // Update is called once per frame
    void Update()
    {  

        if(timeBtwSpawns <= 0 && !IconCoffee.activeSelf && !IconMonster.activeSelf){ // so that no more power up spawn, temporary
            //if(spawnlings[0] == null){
                Transform randomSpawnPoint = SpawnPoint[Random.Range(0, SpawnPoint.Length)];
                GameObject randomProjectile = projectile[Random.Range(0, projectile.Length)];
                spawn = new Vector3(Random.Range(minDistance, maxDistance), -900, 0);
                GameObject spawnling = Instantiate(randomProjectile, randomSpawnPoint.localPosition, Quaternion.identity) as GameObject;
            
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
