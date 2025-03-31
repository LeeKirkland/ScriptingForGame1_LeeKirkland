using UnityEngine;

public class Dog : Mammal
{
    public string dogBreed;     //we can set
    public bool hasFur;     //true or false

    public GameObject dogSpawn;     //what we want to instanciate with GiveBirth()      Assume this is a prefab of a dog

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()     //because mammals has a protecected function
    {
        base.Start();
        
    }
      
    public void InitializeDog(string breed, bool fur)       //passing throuh string and bool
    {
        dogBreed = breed;       //saying it has a breed you can access
        hasFur = fur;       //saying that hasFur is having fur
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GiveBirth();
        }
    }

    public void Bark()      //dont need to make this a virtual void bec we arent going to get anymore specific
    {
        Debug.Log("Bark bark bark bark");
        Debug.Log("This wakes up the neighbors");

    }
    public override void GiveBirth()        //if its public in one it has to be public in the other
    {
        GameObject go = Instantiate(dogSpawn);      //spawns dog
        go.GetComponent<Dog>().InitializeDog("Chipoo", true);
    }
}
