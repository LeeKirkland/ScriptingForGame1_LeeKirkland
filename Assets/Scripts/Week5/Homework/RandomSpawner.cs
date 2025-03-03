using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject toadPreFab; 
    public float spawnRange = 20;   
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 30f; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPrefab();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnPrefab()
    {
      
        float randomX = Random.Range(-82.2f, 87f);
        float randomY = Random.Range(47.1f, -57.1f); 
        float randomZ = Random.Range(63.5f, 63.5f);

        Vector3 spawnPosition = new Vector3(randomX, randomY);

       
        GameObject spawnedObject = Instantiate(toadPreFab, spawnPosition, Quaternion.identity);


        float randomLifetime = Random.Range(1f, 30f);  

       
        Destroy(spawnedObject, randomLifetime);

       
        float randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnPrefab", randomInterval);
    }
}
