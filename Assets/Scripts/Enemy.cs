using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;
    GameObject clone;

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            clone = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Destroy(clone, 1.0f);
    }
}
