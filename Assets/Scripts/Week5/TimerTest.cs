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
        timerMaxDuration = Random.Range(1, 5);    //because we want it to go between one 1 , 4
                                                  //if u put an f after it will return a decimal. if you do NOT it will return a while number friom the first nuumber to the last not including the 
                                                  //last number. if 1f and 4f it will return a number between 1 and 4 

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

        if (cube.transform.transform.position.x < 10)    //makes it so the cube only moves when it is less than 10 on the x axis (calling based on position so it doesnt go forever(end condition))
        {
            Invoke("MoveCubeRight", timerMaxDuration);    //going to call itself AGAIN after 3 seconds (is going to do it forever)
        }
    }

}