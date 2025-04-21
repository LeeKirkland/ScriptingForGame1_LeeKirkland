using UnityEngine;

public class Bouncing : MonoBehaviour
{
    float moveX;
    float moveY;
    public float speed = 5f;
    private float moveDir;
    private Vector3 randomDirection;
    


    void Start()
    {
        randomDirection = new Vector3(Random.Range(-9.81f, 4.71f), Random.Range(10.14f, 4.71f), Random.Range(1f, 1f)).normalized;

        moveX = Random.Range(1f, 2f);
        moveY = Random.Range(1f, 2f);
    }
 

    void Update()
    {
        transform.Translate(randomDirection * speed * Time.deltaTime);

        // transform.position += direction * speed;
       // this.transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        //if we hit horizontal wall: multiply direction.x * -1;
        //if we hit vertical wall: multiply direction.y * -1;
    }


}