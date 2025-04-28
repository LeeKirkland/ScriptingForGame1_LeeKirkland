using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 2f;
    private Vector2 direction;

    private void Start()
    {
        direction = Random.insideUnitCircle.normalized;
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 0.1f);
        if (hit.collider != null && hit.collider.CompareTag("Wall"))
        {
            Bounce(hit.normal);
        }
    }

    private void Bounce(Vector2 normal)
    {
        direction = Vector2.Reflect(direction, normal).normalized;
    }
}
