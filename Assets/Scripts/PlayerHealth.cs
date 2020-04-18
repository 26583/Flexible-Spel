using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int health = 100;
    [SerializeField]
    PlayerDamage playerDamage;

    void Start()
    {
        playerDamage.damageTaken += DamageControl;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    public int GetHealth()
    {
        return health;
    }
    public void DamageControl()
    {
        TakeDamage(10);
        if (health < 0)
        {
            health = 0;
            Destroy(gameObject);
        }
    }
}
