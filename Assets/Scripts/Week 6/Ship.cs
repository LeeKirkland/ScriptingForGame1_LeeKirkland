using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Cannon> cannons = new List<Cannon>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.InstanceID).ToList();  //need to add system.linq to the top

        cannons[0].FireCannon();  //will fire the first cannon in the list
        cannons[1].FireCannon(); //will fire second cannon in the list
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireAllCannons();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FireEvenCannons();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireOddCannons();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            FireAllPowerfulCannons();
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            FireAllWeakCannons();
        }
    }

    void FireAllCannons()
    {
        //this fires all the cannons using a foreach loop
        foreach (Cannon c in cannons)
        {
            c.FireCannon();
        }

        //This commented out for loop does the same as the foreach loop, where it goes through all the elements in the list and fires them.
        /*
        for (int i = 0; i < cannons.Count; i++)
        {
            cannons[i].FireCannon();
        }
        */
    }

    void FireEvenCannons()
    {
        for (int i = 0; i < cannons.Count; i++)   //make sure all three pieces are seperated by semi colon but not one at the end :))
                                                  //asking if i is less than number of cannons in list 
        {
            //if its odd, dont fire
            //if its even, fire
            //% does division and gives u the remainder.
            if (i % 2 == 0)
            {
                cannons[i].FireCannon();
            }
        }
    }

    void FireOddCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (i % 2 == 1)
            {
                cannons[i].FireCannon();
            }
        }
    }

    void FireAllPowerfulCannons()
    {
        foreach(Cannon c in cannons)
        {
            if(c.forcePower >= 4500)
                    {
                c.FireCannon();
            }

        }
    }

    void FireAllWeakCannons()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            if(cannons[i].forcePower < 4500)
            {
                cannons[i].FireCannon();
            }
        }
    }
}
