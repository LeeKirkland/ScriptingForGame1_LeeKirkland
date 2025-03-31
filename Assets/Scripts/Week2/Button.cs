using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject button;  
    public LightManager lightManager;

    void Start()
    {
        
    }
    private void Update()
    {
      
    }
    public void TurnLightOn()

    {
        lightManager.TurnLightsOn();  

       
        if (lightManager.lightToToggle1.enabled && lightManager.lightToToggle2.enabled)
        {
            button.SetActive(false);  
        }
    }
}
