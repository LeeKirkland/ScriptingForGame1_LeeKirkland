using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    public GameObject preFabToSpawn;
    public Transform preFabSpawnPosition;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cannonball")
        {
            Instantiate(preFabToSpawn, preFabSpawnPosition.position, preFabSpawnPosition.rotation);

            }
    }
}
