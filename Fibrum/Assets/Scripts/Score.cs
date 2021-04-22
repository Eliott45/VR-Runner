using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] Text _score;
    float _time = 0;

    void Update()
    {
        _time += Time.deltaTime;
        _score.text = "Score: " + Math.Round(_time, 0);
        if(_time > 50)
        {
            SceneManager.LoadScene("ReStartMenu(Win)");
        }
    }
}
