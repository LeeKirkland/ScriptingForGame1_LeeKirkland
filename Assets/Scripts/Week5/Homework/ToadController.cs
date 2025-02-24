using UnityEngine;

public class ToadController : MonoBehaviour

{
    public GameObject toadPreFab;
    public GameObject mushroomPreFab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddRandomForce()  //want to call this on each of the toads on the list script
    {
        Vector3 randomDirection = Vector3.zero;
        randomDirection.x = Random.Range(-1f, 1f);
        randomDirection.y = Random.Range(0f, 1f);
        randomDirection.z = Random.Range(-1f, 1f);

        float forceMultiplier = Random.Range(1000f, 5000f);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * forceMultiplier);
    }

}
