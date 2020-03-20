using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int health = 100;
    public event Action<int> HealthChanged;
    public event Action Death;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Death();
        }
        else
        {
            HealthChanged(health);
        }
    }
}
