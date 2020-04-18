﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerDamage : MonoBehaviour
{
    PlayerHealth healthClass;
    PlayerHealthDisplay healthDisplay;
    public event Action damageTaken;
    void Start()
    {
        healthClass = gameObject.GetComponent<PlayerHealth>();
        healthDisplay = gameObject.GetComponent<PlayerHealthDisplay>();
    }
    void OnMouseDown()
    {
        damageTaken();
    }
}
