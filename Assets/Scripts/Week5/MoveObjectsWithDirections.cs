using UnityEngine;

public class MoveObjectsWithDirections : MonoBehaviour
{

    public GameObject point1;
    public GameObject point2;

    public float speed = 4f;

    public bool hasReachedDestination = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    /*
    void Update()
    {
        //this gets the direction every frame. updating when point 1 moves
        //this causes the point1 object to steadily creep towards point 2, slowing down
        //as is aproaches because the dirtection is getting smaller
        Vector3 direction;

        direction = point2.transform.position = point1.transform.position;
        Debug.Log(direction);

        point1.transform.position += direction * Time.deltaTime;

    }*/

    /*
    private void Update()
    {
        Vector3 direction;
        direction = point2.transform.position - point1.transform.position;

        //makes it not slow down as it approaches other point
        direction = direction.normalized;
        Debug.Log(direction);

        point1.transform.position += direction *  speed * Time.deltaTime ;
    }
    */
    //this version normalizes the direction of the movement vector, so it travels steadily twoard point2, multiplied by the speed variable so it can speed up
    //it jitters as it reaches the end bec it always moves past the exact location of point2, so it goes back and forth until; it tries to reach the exact point 
    /*
    private void Update()
    {
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;

        //makes it not slow down as it approaches other point
        direction = direction.normalized;

        Debug.Log(Vector3.Distance(point1. transform.position, point2.transform.position)); //how far is this object from this object (so u dont have to use distance formula)

        if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
        {
            point1.transform.position = point2.transform.position;
        }
        else
        {
            point1.transform.position += direction * speed * Time.deltaTime;
        }
    }
    */
//we check the distqance between point1 and point2. if it is close enough (within .1 unit), it teleports point1 ionto point2, which is visually not noticable. it will stop trying to move point1 
//towards point2 bec it is already on top og it and therefore within distance. however
    private void Update()
        //this version of update will only run if point1 hasnt reached itws destination. now it will stop running all copde in update once it hqas reached its desitnation
        //bec we have hasReachedDestination bool variable rthat checks if it hasnt. but once it does reach it, we set thtat bool to true
    {
        if(hasReachedDestination == false)   //free to have stuff check in a line and apply whatever is true and false
        { 
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;
       
        direction = direction.normalized;    //makes it not slow down as it approaches other point


            Debug.Log(Vector3.Distance(point1. transform.position, point2.transform.position)); //how far is this object from this object (so u dont have to use distance formula)

            if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f) //saying if its close enough, teleport it top destination
            {
                point1.transform.position = point2.transform.position;
                hasReachedDestination = true;

            }
            else
            {
                point1.transform.position += direction * speed * Time.deltaTime;
            }
        }
    }
}



