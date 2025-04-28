using UnityEngine;

public class inclassbounce : MonoBehaviour
{
    private Vector3 direction;
    float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "TopOrBottomWall")
        {   
        direction.y *= -1f;
        }
        else if (collision.collider.tag == "SideWall")
        {
        direction.x *= -1f;
        }
    }
}
