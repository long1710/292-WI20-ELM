﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = txt.GetComponent<Text >();
        txt.text = "High Score: " + PlayerPrefs.GetInt("highscore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
