using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject cannonBallPrefab;

    public GameObject CannonBallSpawnposition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    //this instantiate version spaen the camnnonBallprefab, at the cammpmBallSpawn's position, with the same rotation it is in the prefab
    
    {
       GameObject go = Instantiate(cannonBallPrefab, CannonBallSpawnposition.transform.position, Quaternion.identity);

        go.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))  //if we are holding down the space key...
        {
            Instantiate(cannonBallPrefab, CannonBallSpawnposition.transform.position, Quaternion.identity);

        }
    }
}