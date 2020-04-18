using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField]
    PlayerDamage playerDamage;
    // Start is called before the first frame update
    void Start()
    {
        playerDamage.damageTaken += camShake;
    }
    void camShake()
    {
        Debug.Log("SHAKING!!");
    }
}
