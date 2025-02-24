using UnityEngine;

public class StartButton : MonoBehaviour
{
    public Light lightToToggle1; 

    public void TurnLightOnOff()

{
    lightToToggle1.enabled = !lightToToggle1.enabled;
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
