using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int Plife = 1;

    public void Update()
    {
        if (Plife <= 0)
        {
            SceneManager.LoadScene("Derrota");
            Destroy(gameObject);
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EB"))
        {
            Plife -= 5;
        }
    }
}
