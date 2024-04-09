using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser_Enemy : Enemy_Base
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
   protected override void Update()
    {
        //follows the target
        nav.SetDestination(target.position);
        //movement speed
        nav.speed = 10;
    }
}
