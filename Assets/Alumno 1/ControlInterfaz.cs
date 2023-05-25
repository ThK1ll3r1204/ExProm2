using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInterfaz : MonoBehaviour
{
    public GameObject interfazObject;
    public float tiempoInactividad = 0f;
    public float umbralInactividad = 5f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ResetInactividad();
        }
        else
        {
            tiempoInactividad += Time.deltaTime;

            if (tiempoInactividad >= umbralInactividad)
            {
                interfazObject.SetActive(false); 
            }
        }
    }

    private void ResetInactividad()
    {
        tiempoInactividad = 0f;
        interfazObject.SetActive(true); 
    }
}