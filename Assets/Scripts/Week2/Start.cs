
using UnityEngine.UI;


public class NewMonoBehaviourScript : MonoBehaviour
{

    public Light lightToToggle1;
    public Light lightToToggle2;
    public Button toggleButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (lightToToggle1 != null && toggleButton != null)
        {
            toggleButton.onClick.AddListener(ToggleLight1);
        }

         if (lightToToggle2 != null && toggleButton != null)
        {
            toggleButton.onClick.AddListener(ToggleLight2);
        }
    }
 void ToggleLight()
    {
        if (lightToToggle1 != null)
        {
            lightToToggle1.enabled = !lightToToggle1.enabled;
        }

         if (lightToToggle2 != null)
        {
            lightToToggle2.enabled = !lightToToggle2.enabled;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
