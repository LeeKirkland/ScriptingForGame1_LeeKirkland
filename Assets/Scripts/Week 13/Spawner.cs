using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PacmanSprite;
    float numToSpawn;
    public float minSpawn = 1f;
    public float maxSpawn = 20f;

    public Transform SpriteBackground;
    public Transform SpritePosition;
  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        SpriteBackground.position = new Vector3(SpriteBackground.position.x, SpriteBackground.position.y, -1);
        SpritePosition.position = new Vector3(SpritePosition.position.x, SpritePosition.position.y, 0);


        numToSpawn = Random.Range(20f, 50f);
        for (int i = 0; i < numToSpawn; i++)
        {
            Debug.Log("Sprite Spawned");
            Vector3 randomPosition = new Vector3(Random.Range(-9.81f, 4.71f), Random.Range(10.14f, 4.71f), Random.Range(1f, 1f));
           // instance.transform.GetPosition = transform.position + randomPosition;

            Vector3 direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;


        }
    }

    // Update is called once per frame
    void Update()
       
    {

        SpawnSprite();

        //clicking would go on everything 
      if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D rayhit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

      if (rayhit.transform != null)
            {
                return;
            }
            if (rayhit.collider.tag == "Pacman")
            {
                Debug.Log("Correct!");
            }
            else
            {
                Debug.Log("hits something else");
            }
        }
    }
    void SpawnSprite()
      {
          float randomX = Random.Range(-9.81f, 4.71f);
          float randomY = Random.Range(10.14f, 4.71f);
          float randomZ = Random.Range(1f, 1f);

          Vector3 spawnPosition = new Vector3(randomX, randomY, randomZ);

        // Sprite spawnedObject = Instantiate(PacmanSprite, spawnPosition, PacmanSprite.transform.rotation);

      }
    /*private void OnMouseDown()
    {
        //destroy the game object after clicking on it 
        Destroy(PacmanSprite);
    }
    */

  
}
