using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LiveConditions : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Escena de derrota
        }

        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            //Escena de Derrota
            Debug.Log("MUERE");
        }

        if (collision.gameObject.CompareTag("Win"))
        {
            //Escena Nivel 3
        }

    }

}
