﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public GameObject IconCoffee;
    public GameObject IconMonster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IconCoffee.activeSelf && IconMonster.activeSelf)
            IconCoffee.SetActive(false);
    }
}