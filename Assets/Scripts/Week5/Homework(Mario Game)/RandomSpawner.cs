using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject toadPreFab;
    float numToSpawn;  
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 30f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get Random number to spawn
        numToSpawn = Random.Range(20f, 40f);
        //Make a for loop that goes for that random number

        for(int i=0; i < numToSpawn; i++)
        {
            SpawnPrefab();
        }
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

        Vector3 spawnPosition = new Vector3(randomX, randomY, randomZ);

       
 
        GameObject spawnedObject = Instantiate(toadPreFab, spawnPosition, toadPreFab.transform.rotation);


        //float randomLifetime = Random.Range(1f, 30f);  


        //Destroy(spawnedObject, randomLifetime);


        //float randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        //Invoke("SpawnPrefab", randomInterval);
    }
}
