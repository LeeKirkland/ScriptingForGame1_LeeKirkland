using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;     // Prefab for ghost
    public int numberToSpawn = 5;      // Number of ghosts to spawn
    public float spawnRadius = 10f;    // Radius for random spawn positions

    private bool hasSpawned = false;   // Flag to ensure spawning only once

    void Start()
    {
        if (!hasSpawned)
        {
            SpawnGhosts();
            hasSpawned = true;  // Prevent spawning multiple times
        }
    }

    // Function to spawn ghosts
    void SpawnGhosts()
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            // Generate a random position within the spawn radius
            Vector2 circle = Random.insideUnitCircle * spawnRadius;
            Vector3 spawnPos = new Vector3(circle.x, 0f, circle.y) + transform.position;

            // Instantiate the ghost at the random position
            GameObject ghost = Instantiate(ghostPrefab, spawnPos, Quaternion.identity);

            // Set the random direction for each ghost
            Movement mover = ghost.GetComponent<Movement>();
            if (mover != null)
            {
                mover.moveDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
            }
        }
    }
}
