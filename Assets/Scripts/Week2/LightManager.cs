using UnityEngine;

public class LightManager : MonoBehaviour
{
    public Light lightToToggle1;
    public Light lightToToggle2;


    void Start()
    {
        lightToToggle1.enabled = false;
        lightToToggle2.enabled = false;

        Debug.Log("Lights are off");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            lightToToggle1.color = Color.green;
            lightToToggle2.color = Color.blue;

            Debug.Log("Lights changed to green and blue");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            lightToToggle1.color = Color.blue;
            lightToToggle2.color = Color.green;

            Debug.Log("Lights changed to blue and green");
        }
    }


    public void TurnLightsOn()
    {
        lightToToggle1.enabled = true;
        lightToToggle2.enabled = true;
        Debug.Log("Lights are turned on");
    }
}

