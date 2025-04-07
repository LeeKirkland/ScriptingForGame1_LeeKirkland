using UnityEngine;

public class RangedEnemy : Enemy
{
    public GameObject projectilePreFab;

    public Transform projectileSpawnPosition;

    public float projectileForce = 500f;

    protected override void Attack()        //when atk is called shoot projectile towards player
    {
       GameObject go =  Instantiate(projectilePreFab, projectileSpawnPosition.position, projectileSpawnPosition.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * projectileForce);
    }



    //function to make it face the player
 protected override void Update()
    {
       // this.transform.LookAt(player.transform.position);
        base.Update();

    }

}
