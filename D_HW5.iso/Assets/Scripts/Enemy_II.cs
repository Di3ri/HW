using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_II : Enemy
{
    protected override void Start()
    {
        base.Start();

    }
    // Update is called once per frame
    protected override void Update()
    {
        //enemy runs away at random
        base.Update();
    }
}
