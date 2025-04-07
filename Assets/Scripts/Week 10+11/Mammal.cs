using UnityEngine;

public class Mammal : Animal        //inherits from Animal - we dont lose the ability to put this on an object bec animal inherits form monobehavior and this inherits animal 
{
    protected virtual void Start()      //protected is going to make it public to any children of this class but not to anything else :)
    {
        bType = BloodType.WarmBlooded;
    }

    public override void Eat(int energyGained)      //override eat function 
    {
        Debug.Log("Chomp Chomp eating with mouth");
        base.Eat(energyGained);                             //calls eat function so it increases energy but since override we can do anything we want 
    }

    public virtual void GiveBirth()
    {
        Debug.Log("giving birth to a mammal");        //instancaiting something 
    }
}
