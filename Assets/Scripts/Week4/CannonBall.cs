using UnityEngine;

public class CannonBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        
    }

    public void AddRandomForce()  //want to call this on each of the cannonballs on the list script
    {
        Vector3 randomDirection = Vector3.zero;
        randomDirection.x = Random.Range(-1f, 1f);
        randomDirection.y = Random.Range(0f, 1f);
        randomDirection.z = Random.Range(-1f, 1f);

        float forceMultiplier = Random.Range(1000f, 5000f);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * forceMultiplier);
    }



    private void OnCollisionEnter(Collision otherObject)
    {
        Debug.Log(otherObject.gameObject.name);

        if(otherObject.gameObject.tag == "floor")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            otherObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            otherObject.gameObject.GetComponent<FloorScript>().SayHello();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
         
    }
    private void OnTriggerExit(Collider other)
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
