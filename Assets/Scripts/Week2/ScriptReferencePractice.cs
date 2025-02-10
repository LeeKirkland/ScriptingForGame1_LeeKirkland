using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public UI_1 wrigglersController;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wrigglersController.scaleIncrease = 5f;
        wrigglersController.RotateWrigglers();
        wrigglersController.RotateWrigglers();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
