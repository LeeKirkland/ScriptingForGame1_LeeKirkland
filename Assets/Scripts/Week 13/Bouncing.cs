using UnityEngine;

public class Bouncing : MonoBehaviour
{
    float moveX;
    float moveY;
    public float speed = 5f;
    private float moveDir;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveX = Random.Range(1f, 2f);
        moveY = Random.Range(1f, 2f);
    }
 
    // Update is called once per frame
    void Update()
    {
        ;// transform.position += direction * speed;

        this.transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        //if we hit horizontal wall: multiply direction.x * -1;
        //if we hit vertical wall: multiply direction.y * -1;
    }


}