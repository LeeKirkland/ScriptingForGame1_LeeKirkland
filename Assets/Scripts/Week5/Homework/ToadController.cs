using UnityEngine;
using UnityEngine.UI;

public class ToadController : MonoBehaviour

{
 
    public float totalTime = 10f;      
    public Text spawnCountText;       

    private int spawnCount = 0;        
  /*  private float timer = 0f;     */

    public Rigidbody rbody;
    public Vector3 moveDirection;
    public float speed;


  
    void Start()

    {
        rbody = GetComponent<Rigidbody>();
    }

    public void Movement()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Random.Range(-1f, 1f);
        direction.y = Random.Range(-1f, 1f);
        this.gameObject.GetComponent<Rigidbody>().AddForce(direction * 15f);
        

        Debug.Log("This is working");

    }

    public void OnCollisionEnter(Collision plane)
    {
       if(plane.gameObject.tag == "plane" )
        {
            Movement();

        }
    }

     void Update()
    {
        rbody.AddForce(moveDirection * speed * Time.deltaTime); 
    }



    /* {
    Invoke("SpawnPrefab", Random.Range(minSpawnInterval, maxSpawnInterval));
}

void Update()
{
    timer += Time.deltaTime;


    if (timer >= totalTime)
    {
        CancelInvoke("SpawnPrefab");
        DisplaySpawnCount();          
    }
}
void SpawnPrefab()
{

    float randomX = Random.Range(-spawnRange, spawnRange);
    float randomY = Random.Range(1f, 5f);  
    float randomZ = Random.Range(-spawnRange, spawnRange);

    Vector3 spawnPosition = new Vector3(randomX, randomY, randomZ);


    GameObject spawnedObject = Instantiate(toadPreFab, spawnPosition, Quaternion.identity);


    spawnCount++;


    float randomLifetime = Random.Range(2f, 5f);  
    Destroy(spawnedObject, randomLifetime);  


    RandomMovement randomMovement = spawnedObject.AddComponent<RandomMovement>();
    randomMovement.moveSpeed = Random.Range(1f, 3f);  

    Invoke("SpawnPrefab", Random.Range(minSpawnInterval, maxSpawnInterval));
}
*/

    void DisplaySpawnCount()
    {
     
        if (spawnCountText != null)
        {
            spawnCountText.text = "Prefabs Spawned: " + spawnCount.ToString();
        }
        else
        {
            Debug.Log("No Text UI element assigned to display the count.");
        }
    }
}