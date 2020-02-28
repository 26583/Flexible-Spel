using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int health = 100;
    [SerializeField]
    Text healthCounter;
    
    void Start()
    {
        RefreshHealthCounter();
    }
    void OnMouseDown()
    {
        health -= 10;
        Debug.Log(health);
        if(health < 0)
        {
            health = 0;
            Destroy(gameObject);
        }
        RefreshHealthCounter();
    }
    void RefreshHealthCounter()
    {
        healthCounter.text = "Health: " + health;
    }
}
