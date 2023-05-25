using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveConditions : MonoBehaviour
{
    [SerializeField] float _plife;
    


    void Start()
    {
        _plife = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeLife(float value)
    {
        _plife += value;

        if(_plife <= 0)
        {
            //Escena de Derrota
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ChangeLife(-2);
        }

        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            ChangeLife(-1);
        }

        if (collision.gameObject.CompareTag("Win"))
        {
            //Escena Nivel 3
        }

    }

}
