using UnityEngine;

public class ListReview : MonoBehaviour
{ 
    public List<GameObject> cubes;      //needs the list thing at the top from unity 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubes[0].SetActive(false);
        cubes[cubes.count -1]

            foreach(GameObject c in cubes)      //iteratesd though all objects in the list called "cubes". when in the for each loop the individual element will be referenced as "c"
        {
            Debug.Log(c.name);      //displays the name of weach cube in the list
        }

        for (int i = 0; i < cubes.Count; i++)       //will keep counting up until condition is met 
        {
            Debug.Log(cubes[i].name);

            if(i % 2 == 0 )     //if i divided by 2 has a remainder of 0, this means its even 
            {
                Debug.Log(cubes[i].name + "is an even element!");
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
