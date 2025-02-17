using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{
    public float timerCountingDown =3f;
    public float timerMaxDuration = 0f;
    public float defaultTime = 3f;

    public bool timerhasFinished = false; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerCountingDown = defaultTime;
    }

    // Update is called once per frame
    void Update()
    {
        timerCountingDown -= Time.deltaTime;

            if(timerCountingDown <= timerMaxDuration)
                {
                Debug.Log("reached End of Timer!:)");
            timerCountingDown = defaultTime;

            }
    }
}
