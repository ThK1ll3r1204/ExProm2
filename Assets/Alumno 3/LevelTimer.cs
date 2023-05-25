using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    public float lvlTimer;
    public TextMeshProUGUI UItimer;

    void Update()
    {
        lvlTimer -= Time.deltaTime;

        if(lvlTimer <= 0)
        {
            SceneManager.LoadScene(3);
        }

        int minutes = (int)lvlTimer / 60;
        int seconds = (int) lvlTimer - (minutes * 60);

        if(seconds < 10)
            UItimer.text = "0" + minutes + ":0" + seconds;
        else
            UItimer.text = "0" + minutes + ":" + seconds;
    }
}
