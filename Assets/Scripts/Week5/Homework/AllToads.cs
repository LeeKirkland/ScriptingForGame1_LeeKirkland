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
        toads = FindObjectsByType<ToadController>(FindObjectsSortMode.None).ToList();

        GameObject.FindGameObjectsWithTag("Toad").ToList();

        GameObject go = Instantiate(toadPreFab);

        toads.Add(go.GetComponent<ToadController>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
