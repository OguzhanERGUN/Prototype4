using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public GameObject powerUpPrefab;
    public bool isEverybodyDead;
    public int enemyCount;
    public int spawnCount = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        SpawnEnemy();
    }









    void SpawnEnemy()
    {
        if (enemyCount == 0)
        {
            for (int i = 0; i < spawnCount; i++)
            {
                int index = Random.Range(0, enemyPrefab.Length);
                Instantiate(enemyPrefab[index], ReturnSpawnPosition(), enemyPrefab[index].transform.rotation);
                enemyCount++;
            }
            Instantiate(powerUpPrefab, ReturnSpawnPosition(), powerUpPrefab.transform.rotation);
            spawnCount++;
        }

    }

    Vector3 ReturnSpawnPosition()
    {
        float spawnPosX = Random.Range(-10, 10);
        float spawnPosZ = Random.Range(-10, 10);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
