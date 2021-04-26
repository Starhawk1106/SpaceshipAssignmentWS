using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{

    public GameObject meteorPrefab;

    public float minSpawnDelay = 1f;

    public float maxSpawnDelay = 3f;

    public float spawnXLimit = 6f;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        float random = Random.Range(-4, 4);
        Vector3 spawnPos = transform.position + new Vector3(0f, 0f, random);
        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);

        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
