using UnityEngine;

public class PlayerInventory : MonoBehaviour           //concept of having a trigger that is picked up and changes something/ pick up, adds to inventory, can use elsewhere (can use to pick smth up and increase health etc)
{

    public KeyColor doorColor;


    public bool hasRedKey = false;
    public bool hasBlueKey = false;
    public bool hasYellowKey = false;
    public GameObject playerCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //are we looking at the door
            RaycastHit hitObject;  //this variable containes the data of what will be hit by the raycast

            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitObject, 10f))  //looks in front of us 
            {
                if(hitObject.collider.gameObject.tag == "Door")    //if thing in front of us is "door"
                {
                    Door lookedAtDoor = hitObject.collider.gameObject.GetComponent<Door>();

                    if(lookedAtDoor.doorColor == KeyColor.Red && hasRedKey == true)
                    //if the door color is red AND if the player has the key
                    {
                        lookedAtDoor.OpenDoor();
                    }
                    else if(lookedAtDoor.doorColor == KeyColor.Blue && hasRedKey ==true)
                    {
                        lookedAtDoor.OpenDoor();

                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Yellow && hasYellowKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                    


                  /*  if(hasKey == true)                      //and we have the key
                    {
                        hitObject.collider.gameObject.GetComponent<Door>().OpenDoor();      //no matter how many doors are in the scene we can call this function for the object we are looking at 

                    }
                  */
                }
            }

        }
    }


                                                                    //player can walk up to door and press e and if player has the key the door will open 
    private void OnTriggerEnter(Collider other)         //when player walks over key it disapears
    {
        if (other.gameObject.tag == "Key")        
        {
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;

            if(pickedUpKeyColor == KeyColor.Red)      //asking if key is red
                {
                hasRedKey = true;
                 }
            else if(pickedUpKeyColor == KeyColor.Blue)
            {
                hasBlueKey = true;
            }
            else if (pickedUpKeyColor == KeyColor.Yellow)
            {
                hasYellowKey = true;
            }

            Destroy(other.gameObject);
        }
    }
}
