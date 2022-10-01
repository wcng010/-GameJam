using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : Singleton<AttackCollision>
{
    public bool HealthReduce;
    public GameObject enemy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            HealthReduce = true;
            enemy = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag=="Enemy")
            HealthReduce = false;

    }
}
