using UnityEngine;

public class GhostClickHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray);

            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.CompareTag("Ghost"))
                {
                    Debug.Log("You clicked a ghost!");
                    // Optional: trigger animation, sound, destroy, etc.
                    break;
                }
            }
        }
    }
}
