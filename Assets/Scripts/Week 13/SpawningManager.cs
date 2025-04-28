using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    public GameObject pacmanPrefab;
    public GameObject ghostPrefab1;
    public GameObject ghostPrefab2;
    public GameObject ghostPrefab3;
    public int numberOfGhosts = 10;
    private void Start()
    {

        float randomX = Random.Range(9.34f,-9.59f);
        float randomY = Random.Range(9.62f,-0.37f);

        // Spawn Pacman
        Instantiate(pacmanPrefab, new Vector2(randomX, randomY), Quaternion.identity);

        // Spawn Ghosts
        for (int i = 0; i < numberOfGhosts; i++)
        {
            int randomGhost = Random.Range(1, 4); // 1, 2, or 3

            GameObject ghostToSpawn = null;

            if (randomGhost == 1)
                ghostToSpawn = ghostPrefab1;
            else if (randomGhost == 2)
                ghostToSpawn = ghostPrefab2;
            else if (randomGhost == 3)
                ghostToSpawn = ghostPrefab3;

            Instantiate(ghostToSpawn, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }

}