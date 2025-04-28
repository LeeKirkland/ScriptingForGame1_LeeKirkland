using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public AudioClip successSound;
    public AudioClip missSound;
    public GameObject winScreen;
    public Text missCountText;
    private int missCount = 0;
    private bool gameWon = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameWon)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero, 0f, LayerMask.GetMask("Pacman"));

            if (hit.collider != null)
            {
                WinGame();
            }
            else
            {
                missCount++;
                AudioSource.PlayClipAtPoint(missSound, Camera.main.transform.position);
            }
        }
    }

    private void WinGame()
    {
        gameWon = true;
        AudioSource.PlayClipAtPoint(successSound, Camera.main.transform.position);
        winScreen.SetActive(true);
        missCountText.text = "Misses: " + missCount;
    }
}
