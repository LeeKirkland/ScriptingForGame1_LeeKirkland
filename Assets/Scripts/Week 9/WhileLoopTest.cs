
using System.Collections;
using UnityEngine;

public class WhileLoopTest : MonoBehaviour
{

    public float speed = 3f;
    Coroutine co;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
                while(this.transform.position.x < 7f)               //while the position is less than 7, then move (whats in the brackets)
                {
                    this.transform.position += Vector3.right * speed * Time.deltaTime;
                } */


        co = StartCoroutine(MoveRightAndChangeColor());          //calling the function
    
    }

    // Update is called once per frame
    void Update()
    {
      /*  while(this.transform.position.y < 10)           //crashes unity bec its trying to do what is in the brackets/ finish that every frame
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        } */

      /* StartCoroutine(MoveRightAndChangeColor()); */
      if(Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(co);              //if you want to stop/ get reference to a specific coroutine
        }
      if(Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();            //how to stop it all together
        }
    }

    IEnumerator MoveRightAndChangeColor()           //have to call code bec function
    {
        /*
        Debug.Log("Frame 1 runs");      //this one happens on the first frame
        yield return null;      //yield return null will pause the code until the next frame
        Debug.Log("Frame 2 runs");      //this one happens on the second frame\
        yield return new WaitForSeconds(2f);    //will wait 2 sec before continuing code        (can use this to make a timer as well as invoke)
        Debug.Log("Waited 2 seconds before posting this");
        */

          while(this.transform.position.x < 7f)
        { 
           this.transform.position += Vector3.right * speed * Time.deltaTime;
            yield return null;                                                  //put this here to make it wait until the next frame to continue. start of next frame will restart reading the conditional  
       }                                                                    // asking if its less than 7f
        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.blue;      //will do this after the condition of the while loop is met

        yield return new WaitForSeconds(2f);

            while (this.transform.position.x > -8f)
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
                yield return null;  
        }

            yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
