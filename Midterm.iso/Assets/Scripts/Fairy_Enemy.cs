using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Fairy_Enemy : Enemy_Base
{
    protected override void Start()
    {
        base.Start();
    }

    //make the enemy run around
    protected override void Update()
    {
        nav.SetDestination(transform.position + new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100)));
        //movement speed
        nav.speed = 15;
    }

}
