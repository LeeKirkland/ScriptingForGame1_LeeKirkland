using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;

    public float attackSpeed;

    private float attackTimer;

    protected Player player;      //referencing the script

    //assuming every enemy will have nav mesh agent
    protected NavMeshAgent navAgent;

    [SerializeField]
    protected float aggroRange = 30f;

    protected bool hasSeenPlayer = false;

    //adding points that we want the enemy to patrol to 
    [SerializeField]        //will let us see protected in the inspector for whatever it is over
    protected List<Transform> patrolPoints = new List<Transform>();

    protected int patrolPointIndex = 0; //use this to determine which patrol point we are at and keep track of it 

    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();     //ref the script now not a game object
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(patrolPoints[patrolPointIndex].position);      //acess to the first patrol point transform and need the .position to get reference to its position
    }


    protected virtual void Update()
    {
        if (hasSeenPlayer == true)
        {
            if (navAgent.remainingDistance < 0.5f)      //if enemy reached the LAST KNOWN location of the player
            {
                if (Vector3.Distance(this.transform.position, player.transform.position) > aggroRange)      
                {
                    hasSeenPlayer = false;      //enemy no longer sees player and will be forces to return to other patrol patha
                }
                else// they are NOT within line of sight
                {
                    if (IsPlayerInLoS() == true)
                    {
                        navAgent.SetDestination(player.transform.position);
                        navAgent.isStopped = false;

                    }
                    else
                    {
                            //if the player is within the range but not within line of sight
                    }
                    {
                        hasSeenPlayer = false;
                    }
                }
            }
            //if the player is within attk range
            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)     
            {
                if (IsPlayerInLoS() == true)    //and if the player is in line of sight
                {
                    navAgent.SetDestination(player.transform.position);     //chase the palyer
                    navAgent.isStopped = false;     //and make sure its allowed to move
                }
            }
            else//if the player IS within atk range
            {
                if (IsPlayerInLoS() == true)//and the player is within los
                {
                    navAgent.isStopped = true;//stop the movement 
                    this.transform.LookAt(player.transform.position);       //keep looking at the player


                    attackTimer += Time.deltaTime;//increase the atk timer

                    if (attackTimer > attackSpeed)//once the atack timer reaches the atk speed
                    {
                        Attack();   //attk
                        attackTimer = 0;//reset timer
                    }
                }
            }
        }
        else//if the player has     NOT been seen 
        {
         
            if (navAgent.remainingDistance < 0.5f)//if the navagent reaches its destination 
            {
                patrolPointIndex++;//increaswe the partol point index so that it will move to the nect patrol point 

                if (patrolPointIndex >= patrolPoints.Count)      //if the patrol point index is out of range
                {
                    patrolPointIndex = 0; //reset its to zero so that it will go back to first point
                }

                navAgent.SetDestination(patrolPoints[patrolPointIndex].position); //set destination to determined point 
            }
        }
    }

    protected bool IsPlayerInLoS()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))     //have to be both in range and in line of sight
        {
            if (hit.collider.tag == "Player")
            {
                return true;
            }
            
        }

        return false;
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

    protected virtual void OnTriggerEnter(Collider other)
    {

        Debug.Log("TriggerEntered");
        if(other.tag =="Player")
        {
            hasSeenPlayer = true;
        }
    }
 public void SeePlayer()
    {
        RaycastHit hit;

         Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if(Physics.Raycast(this.transform.position, dir, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                hasSeenPlayer = true;
            }

        }
    }
}