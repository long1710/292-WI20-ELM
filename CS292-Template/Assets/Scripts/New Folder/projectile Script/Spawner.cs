using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] SpawnPoint;
    public GameObject[] projectile;
    public GameObject Panel;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    
    public float minTimeBetweenSpawns;
    public float decrease;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SpawnPoint.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwSpawns <= 0){
            Transform randomSpawnPoint = SpawnPoint[Random.Range(0, SpawnPoint.Length)];
            GameObject randomProjectile = projectile[Random.Range(0, projectile.Length)];
            //note: can't work on position for now: work on homing position instead
            GameObject spawnling = Instantiate(randomProjectile, randomSpawnPoint.position, Quaternion.identity) as GameObject;
            Debug.Log(randomSpawnPoint.position);
            Debug.Log(SpawnPoint[0].position);
            spawnling.transform.SetParent(Panel.transform, false);

            if(startTimeBtwSpawns > minTimeBetweenSpawns){
                startTimeBtwSpawns -= decrease;
            }

            timeBtwSpawns = startTimeBtwSpawns;
        }
        else {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
