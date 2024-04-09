using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Player;

public class Enemy_Base : MonoBehaviour
{
    protected Transform target;

    protected NavMeshAgent nav;

    protected virtual void Start()
    {
        target = GameManager.instance.Player;
        nav = GetComponent<NavMeshAgent>();
    }

    protected virtual void Update()
    {
        if (Player_Script.allDead)
        {
            Destroy(gameObject);
        }
    }
    
}
