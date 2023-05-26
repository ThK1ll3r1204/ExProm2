using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorUI : MonoBehaviour
{
    public Text loseText;
    public Text creditsText;
    public Text victoryText;

    private int loseCount = 0;
    private int creditsCount = 0;
    private int victoryCount = 0;

    void Start()
    {
        loseText.text = "Perdidas del Papu: " + loseCount;
        creditsText.text = "Los Creditos GOD: " + creditsCount;
        victoryText.text = "Victorias con caramelito incluido: " + victoryCount;
    }

    public void LoadDefeatScreen()
    {
        loseCount++;
        loseText.text = "Perdidas del Papu: " + loseCount;
        SceneManager.LoadScene("Derrota");
    }

    public void LoadCreditsScreen()
    {
        creditsCount++;
        creditsText.text = "Los Creditos GOD: " + creditsCount;
        SceneManager.LoadScene("Creditos");
    }

    public void LoadVictoryScreen()
    {
        victoryCount++;
        victoryText.text = "Victorias con caramelito incluido: " + victoryCount;
        SceneManager.LoadScene("Victoria");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menú");
    }
}
