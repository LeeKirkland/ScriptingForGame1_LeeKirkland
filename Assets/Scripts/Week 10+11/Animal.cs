using UnityEngine;

public enum BloodType
{
    ColdBlooded,
    WarmBlooded
}

public class Animal : MonoBehaviour     //going to be inheriting monobehavior, this is going to let us put monobehavior onto an object
{
    protected int health = 100;             //private would mean that nothing outside of this script could acess this but protected- its children can 
    protected int energy = 100;

    protected BloodType bType;
    public virtual void Eat(int energyGained)       //passing a number through (int energyGain)         vitrual: shouldnt be directly called, is able to be overidden
    {
        energy += energyGained;
    }

}
