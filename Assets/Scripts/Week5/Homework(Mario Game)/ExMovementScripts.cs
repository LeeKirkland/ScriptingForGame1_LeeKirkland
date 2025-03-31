using UnityEngine;

public class ExampleScripts : MonoBehaviour
{
    public Rigidbody rbody;
    public Vector3 moveDir;
    public float speed =5f;
    public float timer = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        ChangeDirection();
        
    }

    // Update is called once per frame
    void Update()
    {
        //use this for moving ridigbodies around that will care abt colliders
        rbody.AddForce(moveDir * speed * Time.deltaTime);
        //use a timer that at the end of the timer, it will reset the timer and then call ChangeDirection()

        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            ChangeDirection();
            timer = 5f;
        }
      
    }
    void ChangeDirection()
    {
        moveDir = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, -1f));
    }
}
