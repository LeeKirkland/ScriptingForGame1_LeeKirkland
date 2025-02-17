using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;

    public bool hasFinishedTimer = false;

    public GameObject cube; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("moveCubeRight", timerMaxDuration); //is going to move cube right AFTER timer max duration (3 seconds)
    }

    // Update is called once per frame
    //in this update once the timer finishes it changes the bool 
    /*
    void Update()
    {
        if(hasFinishedTimer == false)
        { 
        timerCountingUp += Time.deltaTime;
        //Debug.Log(timerCountingUp);

        if (timerCountingUp == timerMaxDuration)
        {
            Debug.Log("Reached End of Timer");
        }
        }
    */

    //in this update the timer counts up but once it reaches the timer max duration it will move the cube to the right without time.deltatime because we want it to move in one motion not
    //overtime. additionally we reset the timer counting up to 0 so that it will count back up to 3 again and move the cube once more.
    /*
    void Update()
    {
        timerCountingUp += Time.deltaTime;

        
        if (timerCountingUp >= timerMaxDuration)
        {
            Debug.Log("Reached End of Timer");
            MoveCubeRight();
            timerCountingUp = 0f;
        }

    }

    */
    void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;
    }

}
