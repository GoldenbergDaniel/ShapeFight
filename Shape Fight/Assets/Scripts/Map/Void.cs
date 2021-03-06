﻿using UnityEngine;

public class Void : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().Die();
        }
        else if (other.CompareTag("Enemy"))
        {
            other.GetComponent<MainEnemy>().Die();
        }
    }
}
