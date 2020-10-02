﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler : MonoBehaviour
{
    public float timer = 0;

    float oldTimer;
    bool isRunning = true;

    void Start()
    {
        oldTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            timer += Time.deltaTime;
            GetComponent<Text>().text = "Tempo: " + Mathf.RoundToInt(timer).ToString() + " s";

            if (timer < 0)
                isRunning = false;
        }
    }
}
