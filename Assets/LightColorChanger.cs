using UnityEngine;

public class LightColorChanger : MonoBehaviour
{
    public Light targetrLight;
    public Button changeColorButton;
    public Color newColor = Color.blue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    if (changeColorButton ! = null)    
    {
        changeColorButton.onClick.AddListener(ChangeLightColor);
    }
}
    // Update is called once per frame
 void ChangeLightColor()
 {
    if (targetLight != null)
    {
        targetLight.color = newColor;
    }
 }
}
