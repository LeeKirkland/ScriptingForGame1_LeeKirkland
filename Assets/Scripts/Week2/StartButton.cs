using UnityEngine;

public class StartButton : MonoBehaviour
{
    public Light lightToToggle1;
    public Light lightToToggle2;
    public GameObject startButton;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        lightToToggle1.enabled = false;
        lightToToggle2.enabled = false;

          Debug.Log("Light is off");

        if (Input.GetKeyDown(KeyCode.A))
        {
            lightToToggle1.color = Color.green;
            lightToToggle2.color = Color.blue;

            Debug.Log("Lights changed");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            lightToToggle1.color = Color.blue;
            lightToToggle2.color = Color.green;

            Debug.Log("lights changed again");
        }
    }

    // Update is called once per frame
    void Update()
    {
   


    }

    public void TurnLightOn()
    {
        lightToToggle1.enabled = true;
        lightToToggle2.enabled = true;

    }
}
