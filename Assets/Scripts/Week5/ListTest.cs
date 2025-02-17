using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour


{ 
public List<CannonBall> cannonballs = new List<CannonBall>();

    public GameObject cannonballPreFab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //finds all objects in the scene that has the CannonBall script on it and tuirns it into a list to be used by the cannonballs variable, which is a list of cannonball scripts
        cannonballs = FindObjectsByType<CannonBall>(FindObjectsSortMode.None).ToList();     //finds all gameobjects in the scene with the specified tag. returns it as an array of game objects
        //that you can conver top a list

        GameObject.FindGameObjectsWithTag("CannonBall").ToList();


        GameObject go = Instantiate(cannonballPreFab);
        //yopu can add an object directly to a list by calling the list cariables name.Add();
        //it must be the same type as the list. if u have a list of gameobjects make sure you give it a gameobject. in this case we have a cannonball script that we want to add to the list of 
        //cannonball scripts
        cannonballs.Add(go.GetComponent<CannonBall>());
    }

    // Update is called once per frame
    //calling from cannon ball script public function
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))       //going to run through everything in the list (each of the cannonballs)
        {

            foreach (CannonBall ball in cannonballs)
            {
                ball.AddRandomForce();
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            int randomBall = Random.Range(0, cannonballs.Count);

   //cannonBalls.Count -1 is in the actual reference to the last element
            cannonballs[cannonballs.Count -1].AddRandomForce();  //calls whatever number you put in in the objects
        }
    }
}
