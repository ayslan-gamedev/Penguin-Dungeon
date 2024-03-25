﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;
    public float health, maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        OnPlayerDamaged?.Invoke();

        if(health <= 0)
        {
            health = 0;
            OnPlayerDeath?.Invoke();
            PlayerManager.isGameOver = true;
            Destroy(gameObject);
        }
    }
}