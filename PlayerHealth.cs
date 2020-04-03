using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int health = 100;
    public int GetHealth()
    {
        return health;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    public void SetHealth(int hp)
    {
        health = hp;
    }
}
