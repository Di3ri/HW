using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_I : Enemy
{
    protected override void Start()
    {
        base.Start();

    }

    protected override void Update()
    {
        //follows the target
        nav.SetDestination(target.position);
        
    }
}
