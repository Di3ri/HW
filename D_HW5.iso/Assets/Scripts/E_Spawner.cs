using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Spawner : MonoBehaviour
{
    //singleton
    public static E_Spawner instance;

    public Enemy[] Villan;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //respawns the enemy
    public void SpawnVillan(int id, Vector3 pos, Quaternion rot)
    {

    }
}
