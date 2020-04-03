﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField]
    Text healthCounter;
    PlayerHealth healthClass;
    // Start is called before the first frame update
    void Start()
    {
        healthClass = gameObject.GetComponent<PlayerHealth>();
        RefreshHealthCounter();
    }
    public void RefreshHealthCounter()
    {
        healthCounter.text = "Health: " + healthClass.GetHealth();
    }
}