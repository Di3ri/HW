using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


    public class Enemy : MonoBehaviour
    {
        protected Transform target;

        protected NavMeshAgent nav;

        //Struct means all enemies have 100 hp
        public struct AllEnemy
        {
            public AllEnemy(int hp)
            {
                Health = hp;
            }

            public int Health;
        }

        protected virtual void Start()
        {
            AllEnemy Villan = new AllEnemy(100);
            target = GameManager.instance.Player;
            nav = GetComponent<NavMeshAgent>();
        }
        //make the enemy run around
        protected virtual void Update()
        {
            nav.SetDestination(transform.position + new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100)));
            //movement speed
            nav.speed = 5;
        }


    }
