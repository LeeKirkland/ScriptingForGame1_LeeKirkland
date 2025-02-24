using UnityEngine;
using UnityEngine.UI;


public class TimerTest : MonoBehaviour
{

public float timeRemaining = 30f; 
public Text timerText;



private bool isRunning = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timer == null)
        {
            Debug.Log("Timer Text is not set to inspector");
            return;
        }


        UpdateTimerDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            
            if(timeRemaining <= 0)
            {
                timeRemaining = 0;
                isRunning = false;
                OnTimerEnd();
            }
        UpdateTimerDisplay();

        }
    }

    void UpdateTimerDisplay()
    {
        float minuets = Mathf.Floor(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = string.Format("{0:00}:{0:30}" , minuets, seconds);

    }
void OnTimerEnd()
{
    Debug.Log("Game Over!");
}

}