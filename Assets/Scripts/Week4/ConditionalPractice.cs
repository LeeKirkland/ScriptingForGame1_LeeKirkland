using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Color go2ElseColor;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ColorgameObjectByName();
        //ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ColorgameObjectByName()
    {

       Debug.Log("go is named" + go.name);
        Debug.Log("go2 is named" + go2.name);

        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();
  

        if (go.name == "Cube")
        {
            //get compontent will look foe the component on the gameObject it is being called on.
            //if there is no component of the type you are trying to get, then use the dot operator after it, it eill throw a null reference exception 

        //if we create a local variable in the function 
            goMeshRenderer.material.color = Color.magenta;
            //Change the color 
        }
        else if (go.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;

            //Change the color to cyan
        }
        else if (go.name == "Cylinder")
        {
            goMeshRenderer.material.color = Color.black;
            //change the color to black
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //change color to orange
        }






        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name =="Cube")
        {
            //get compontent will look foe the component on the gameObject it is being called on.
            //if there is no component of the type you are trying to get, then use the dot operator after it, it eill throw a null reference exception 

            //if we create a local variable in the function 
            go2MeshRenderer.material.color = Color.magenta;
            //Change the color 
        }
        else if (go2.name== "Sphere")
        {
            go2MeshRenderer.material.color = Color.grey;

            //Change the color to grey
        }
        else if (go2.name=="Cylinder")
        {
            go2MeshRenderer.material.color = Color.red;
            //change the color to red
        }
        else
        {
            go2MeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //change color to orange
        }
    }







    void ColorGameObjectByTag()
    {

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.tag == "CoolGuy")
        {
     
            go2MeshRenderer.material.color = Color.grey;
            //Change the color to grey
        }
        else if (go2.tag == "NotCoolGuy")
        {
            go2MeshRenderer.material.color = Color.white;

            //Change the color to white
        }
        else if (go2.tag == "OkayGuy")
        {
            go2MeshRenderer.material.color = Color.red;
            //change the color to red
        }
        else
        {
            go2MeshRenderer.material.color = go2ElseColor;
            //change color to our custom color
        }
    }
}
