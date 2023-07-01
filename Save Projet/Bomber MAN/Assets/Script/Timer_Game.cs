﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;


public class Timer_Game : MonoBehaviour
{
    public float temps = 300f;
    public TextMeshPro text;
    public string LoadingEnd;


    public void Update()
    {
        text.text = string.Format("{0:0}:{1:00}", Mathf.Floor(temps / 60), temps % 60);

        if (temps >= 0)
        {
            temps -= Time.deltaTime;
        }

        if (temps <= 0)
        {
            SceneManager.LoadScene(LoadingEnd);
        }
    }
}

