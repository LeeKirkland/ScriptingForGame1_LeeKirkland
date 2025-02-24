using TMPro;
using UnityEngine;


public class RollCallTimer : MonoBehaviour
{
    public float timer = 30f;

    public TextMeshProUGUI TimerText;

    public bool hasTimerFinished = false;

    public UICounter counterScript;

    public GameObject endScreen;

    public TextMeshProUGUI TotalCountText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        //this script will not allow the player to keep counting
    {
        if (hasTimerFinished == false)
        {
            if (timer > 0)
            {
                timer -=Time.deltaTime;
            }
            else 
            {
                hasTimerFinished = true;
                counterScript.allowCounting = false;
                endScreen.SetActive(true);
                TotalCountText.gameObject.SetActive(true);
                timer = 0f;
            }

            TimerText.text = Mathf.Ceil(timer).ToString("F0");
        }

    }
}
