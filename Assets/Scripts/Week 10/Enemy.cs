using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;

    public float attackSpeed;

    private float attackTimer;

    protected Player player;      //referencing the script



    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();     //ref the script now not a game object
            
    }


    protected virtual void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)     //if player is within attack range, enemy attack
        {
            attackTimer += Time.deltaTime;

            if(attackTimer > attackSpeed)
            {
                Attack();
                attackTimer = 0;
            }
        }
    }

    protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);        //passing in attack damage
        //Call an Animation to attack
        //OR
        //Deal Damage to the Player
    }


    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }


    public void Die()
    {
        //Call Death Animation
        //OR
        //Destroy the Object
    }
}