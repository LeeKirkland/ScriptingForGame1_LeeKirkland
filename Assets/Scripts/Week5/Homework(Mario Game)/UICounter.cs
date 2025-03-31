using TMPro;
using UnityEngine;

public class UICounter : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    public int counter = 0;
    public bool allowCounting = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        //insert bool here
        if (Input.GetKeyDown(KeyCode.D))
        {
            CountDown();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            CountUp();
        }


        void CountUp()
        {
            counter++;
            UpdateCounterUI();
        }
        void CountDown()
        {
            if (counter > 0)
            {
                counter--;

            }
            UpdateCounterUI();
        }

        void UpdateCounterUI()
        {
            CounterText.text = counter.ToString();
        }

    }
}

