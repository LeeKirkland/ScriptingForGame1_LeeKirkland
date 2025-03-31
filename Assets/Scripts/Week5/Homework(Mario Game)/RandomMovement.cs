using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float moveSpeed = 2f; 
    private Vector3 randomDirection;  

    public void Start()
    {
       
        randomDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    public void Update()
    {
   
        transform.Translate(randomDirection * moveSpeed * Time.deltaTime);
    }
}
