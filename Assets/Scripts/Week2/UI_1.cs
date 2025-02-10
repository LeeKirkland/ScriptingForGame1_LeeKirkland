using UnityEngine;

public class UI_1 : MonoBehaviour
{
    public GameObject wrigglers;
    public float scaleIncrease = .5f;
    public GameObject youDiedScreen;

    public Vector3 rotationAmount;
    public Transform teleportTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        wrigglers.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if (wrigglers.transform.localScale.x > 8)
        {
            youDiedScreen.SetActive(true);

        }
<<<<<<< HEAD

=======
        if youDiedScreen.SetActive(true);
>>>>>>> ad9c0eae749a6b474d8d18f048dafed820ec035c
    }
    public void ResetWrigglers()
    {
        wrigglers.transform.localScale = Vector3.one;
        scaleIncrease += .5f;

    }
    public void RotateWrigglers()
    {
        //The following line will rotate wrigglers -360 in z direction by
        //creating a new Vector3 variable to be used onced in a runtime.
        wrigglers.transform.Rotate(new Vector3(0f, 0f, -360f));
        //Alternativly you can create a variable of type Vector3 to pass into thw rotate function,
        //like in the followig line 
        wrigglers.transform.Rotate(rotationAmount);

    }
    public void TeleportWrigglers()
    {
        wrigglers.transform.position = teleportTransform.position;
    }
}
