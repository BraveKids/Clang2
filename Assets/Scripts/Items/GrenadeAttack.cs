﻿using UnityEngine;
using System.Collections;

public class GrenadeAttack : MonoBehaviour
{

    public float m_Damage;
    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Wurm" || col.gameObject.tag == "Tank")
        {
            /*
            if (col.gameObject.tag == "Tank")
            {
                col.gameObject.GetComponentInParent<TankAI>().isDamaged = true;
            }*/

            col.gameObject.GetComponentInParent<EnemyHealth>().Damage(m_Damage);

        }
    }
}