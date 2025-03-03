using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AllToads : MonoBehaviour
{
    public List<ToadController> toads = new List<ToadController>();

    public GameObject toadPreFab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int toadCount = Random.Range(20, 40);
        for (int i = 0; i < toadCount; i++) 
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-80f, 87.99f), Random.Range(-42.3f, 41.73f), 37.52822f);

            GameObject toad = Instantiate(toadPreFab, spawnPosition, toadPreFab.transform.rotation);

            Debug.Log(toadCount);
        }

        toads = FindObjectsByType<ToadController>(FindObjectsSortMode.None).ToList();



        /* toads = FindObjectsByType<ToadController>(FindObjectsSortMode.None).ToList();

         GameObject.FindGameObjectsWithTag("Toad").ToList();

         GameObject go = Instantiate(toadPreFab);

         toads.Add(go.GetComponent<ToadController>());*/
    }
       

    // Update is called once per frame
    /*
     * void Update()
    {
        foreach (ToadController toad in toads)
        {
            toad.Movement();
    
        }
    }
   */
}
