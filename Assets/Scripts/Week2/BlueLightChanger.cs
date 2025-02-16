using UnityEngine;

public class BLueLightChanger : MonoBehaviour
{
    public Light BlueLight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }


   public void StartButton()
    {
        ChangeLightColor(Color.blue);

    }
    // Update is called once per frame
    void Update()
    {
          AdjustLight();
        Debug.Log("LightObject has been Adjusted");

        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeLightColor(Color.green);
        }
    }
}
