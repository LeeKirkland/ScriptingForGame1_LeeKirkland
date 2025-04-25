using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement: MonoBehaviour
{
    public float speed = 5f;
    [HideInInspector] public Vector3 moveDirection;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        if (moveDirection == Vector3.zero)
        {
            // Simple random direction init
            float x = Random.Range(-1f, 1f);
            float z = Random.Range(-1f, 1f);
            moveDirection = new Vector3(x, 0f, z).normalized;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;

        // Bounce based on the wall name or tag
        if (obj.CompareTag("Wall_Left") || obj.CompareTag("Wall_Right"))
        {
            moveDirection = new Vector3(-moveDirection.x, 0f, moveDirection.z);
        }
        else if (obj.CompareTag("Wall_Top") || obj.CompareTag("Wall_Bottom"))
        {
            moveDirection = new Vector3(moveDirection.x, 0f, -moveDirection.z);
        }
    }
}
