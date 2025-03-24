using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalCounterScript : MonoBehaviour


{

    public List<GameObject> enemies = new List<GameObject>();
    public int numEnemies;          //use this to check if you have proper amnt at end\
    public TextMeshProUGUI TotalCountText;
    public GameObject enemyPreFab;
    


  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numEnemies = Random.Range(5, 25);

        for(int i = 0; i < numEnemies; i ++)
        {
            Instantiate(enemyPreFab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if time runs out we will call check player answer
        // CheckPlayerAnswer();
    }

    /*  void CheckPlayerAnswer()
      {
          if (numEnemies == TotalCounterScript.counter)
          {
              Debug.Log("You Win!");
          }
          else
          {
              Debug.Log("You Lose!");
          }
       }*/
}
