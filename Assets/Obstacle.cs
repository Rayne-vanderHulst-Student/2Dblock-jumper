using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float timeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn = Time.deltaTime;
        if (timeToSpawn <= 0.0f)
        {
            SpawnObstacle();
            timeToSpawn = Random.Range(1f, 2f);
        }
    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab,transform.position,Quaternion.identity);
    }
}
