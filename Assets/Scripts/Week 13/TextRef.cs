using TMPro;
using UnityEngine;

public class TextRef : MonoBehaviour
  
{
    public TextMeshProUGUI textObject;
    public int numMissClicks = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    textObject.text = numMissClicks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
