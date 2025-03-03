using UnityEngine;

public enum KeyColor                //makes drop down for diff colors you can choose 
{
    Red, 
    Blue, 
    Yellow
}

public class Key : MonoBehaviour
{
    public KeyColor color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //want to channge color specifically based on the key color

        if(color == KeyColor.Red)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }      

        else if (color == KeyColor.Blue)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;

        }
        else if (color == KeyColor.Yellow)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
