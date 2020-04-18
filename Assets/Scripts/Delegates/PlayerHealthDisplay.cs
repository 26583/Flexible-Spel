using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField]
    Text healthCounter;
    PlayerHealth healthClass;
    [SerializeField]
    PlayerDamage playerDamage;
    void Start()
    {
        healthClass = gameObject.GetComponent<PlayerHealth>();
        RefreshHealthCounter();
        playerDamage.damageTaken += RefreshHealthCounter;
    }
    public void RefreshHealthCounter()
    {
        healthCounter.text = "Health: " + healthClass.GetHealth();
    }
}
