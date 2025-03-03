using UnityEngine;

public class Door : MonoBehaviour
{

    public KeyColor doorColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //want to channge color specifically based on the key color

        if (doorColor == KeyColor.Red)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        
        }

        else if (doorColor == KeyColor.Blue)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;

        }
        else if (doorColor == KeyColor.Yellow)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
           
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //open door function
    public void OpenDoor()
    {
        Destroy(this.gameObject);
    }
}
