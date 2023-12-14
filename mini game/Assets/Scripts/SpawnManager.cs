using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float areaRange = 20f;
    public int coinAmount = 10;
    public GameObject collectibleObject;
    public GameObject ememyObject;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomEnemy();
        SpawnCollectibleObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        Instantiate(ememyObject, new Vector3(0, 1, 5), ememyObject.transform.rotation);
    }

    void SpawnCollectibleObject()
    {
        for(int i = 0; i < coinAmount; i++)
        {
            Instantiate(collectibleObject, CreateRandomSpawnPosition(), collectibleObject.transform.rotation);
        }  
    }

    Vector3 CreateRandomSpawnPosition()
    {
        float xValue = Random.Range(-areaRange, areaRange);
        float zValue = Random.Range(-areaRange, areaRange);
        Vector3 randomPosition = new Vector3(xValue, 1f, zValue);

        return randomPosition;
    }

}
