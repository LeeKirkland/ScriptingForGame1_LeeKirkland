using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> ghosts;

    public GameObject PacmanSprite;
    public GameObject Ghost1Sprite;
    public GameObject Ghost2Sprite;
    public GameObject Ghost3Sprite;
    float numToSpawn;
    public float minSpawn = 1f;
    public float maxSpawn = 10f;

    public Transform SpriteBackground;
    public Transform SpritePosition;
  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteBackground.position = new Vector3(SpriteBackground.position.x, SpriteBackground.position.y, -1);
        SpritePosition.position = new Vector3(SpritePosition.position.x, SpritePosition.position.y, 0);
        //Lists
        ghosts[0].SetActive(false);

        foreach(GameObject g in ghosts)
        {
            Debug.Log(g.name);
        }
        for (int i=0; i < ghosts.Count; i++)
        {
            Debug.Log(ghosts[i].name);

            if(i%2 == 0)
            {
                Debug.Log(ghosts[i].name);
            }
        }

        //spawning
        numToSpawn = Random.Range(5f, 30f);
        for (int i = 0; i < numToSpawn; i++)
        {
            Debug.Log("Sprite Spawned");
            float randomX = Random.Range(10.17f, -9.46f);
            float randomY = Random.Range(9.84f, -0.71f);
            float randomZ = Random.Range(-9.12f, -9.12f);

            Vector3 spawnPosition = new Vector3(randomX, randomY, randomZ);
            GameObject spawnedObject = Instantiate(Ghost1Sprite, spawnPosition, Ghost1Sprite.transform.rotation);
            GameObject spawnedObject = Instantiate(Ghost2Sprite, spawnPosition, Ghost2Sprite.transform.rotation);
            GameObject spawnedObject = Instantiate(Ghost3Sprite, spawnPosition, Ghost3Sprite.transform.rotation);



            // Vector3 randomPosition = new Vector3(Random.Range(-9.81f, 4.71f), Random.Range(10.14f, 4.71f), Random.Range(1f, 1f));
            // instance.transform.GetPosition = transform.position + randomPosition;

            //Vector3 direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;


        }
    }

    // Update is called once per frame
    void Update()
       
    {
  

        //clicking would go on everything -DON'T CHANGE-
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
  

        // Sprite spawnedObject = Instantiate(PacmanSprite, spawnPosition, PacmanSprite.transform.rotation);

    }
    /*private void OnMouseDown()
    {
        //destroy the game object after clicking on it 
        Destroy(PacmanSprite);
    }
    */

  
}
