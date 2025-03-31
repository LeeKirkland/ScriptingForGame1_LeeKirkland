using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;


public class ToadController : MonoBehaviour

{
    public float randomTime;
    public Text spawnCountText;
    public bool isToadBack = false;
    public bool isToadGone = true;

    void Start()
    {
        randomTime = Random.Range(5f, 10f);
    }

    public void Direction()
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = Random.Range(-1f, 1f);
        moveDirection.y = Random.Range(-1f, 1f);
        this.gameObject.GetComponent<Rigidbody>().AddForce(moveDirection * 150f);
        Debug.Log("playing");
    }

    public void Disappear()
    {
        if (isToadGone == true)
        {
            if (randomTime > 0)
            {
                randomTime -= Time.deltaTime;

            }
            else if (randomTime <= 0)
            {
                this.gameObject.SetActive(false);
                randomTime = Random.Range(5f, 10f);
                isToadGone = false;
                isToadBack = true;
            }

        }
        if (isToadBack == true)
        {
            if (randomTime > 0)
            {
                randomTime -= Time.deltaTime;

            }
            else if (randomTime <= 0)
            {
                this.gameObject.SetActive(true);
                randomTime = Random.Range(5f, 10f);
                isToadGone = true;
                isToadBack = false;
            }
        }
    }
   

   private void Update()
    {
      
    }

  
    /*void DisplaySpawnCount()
    {
     
        if (spawnCountText != null)
        {
            spawnCountText.text = "Prefabs Spawned: " + spawnCount.ToString();
        }
        else
        {
            Debug.Log("No Text UI element assigned to display the count.");
        }
    
 
   }
    */
}