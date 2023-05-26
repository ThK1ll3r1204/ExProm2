using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Counter : MonoBehaviour
{
    public int bullets;
    public Text display;

    private void Update()
    {
        display.text = bullets.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EB"))
        {
            bullets--;
            SceneManager.LoadScene("Victoria");
        }
    }
}