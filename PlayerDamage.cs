using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    PlayerHealth healthClass;
    PlayerHealthDisplay healthDisplay;
    void Start()
    {
        healthClass = gameObject.GetComponent<PlayerHealth>();
        healthDisplay = gameObject.GetComponent<PlayerHealthDisplay>();
    }
    void OnMouseDown()
    {
        healthClass.TakeDamage(10);
        if (healthClass.GetHealth() < 0)
        {
            healthClass.SetHealth(0);
            Destroy(gameObject);
        }
        healthDisplay.RefreshHealthCounter();
    }
}
