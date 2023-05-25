using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lacosabailarina : MonoBehaviour
{

public float velocidad = 3f;
public float fuerzaRebote = 5f;
public float tiempoInactividad = 5f;

private Rigidbody2D rb;
private Vector2 direccion;

private void Start()
{
    rb = GetComponent<Rigidbody2D>();
    direccion = GenerarDireccionAleatoria();
}

private void Update()
{
    if (Input.GetMouseButtonDown(0)) 
    {
        ResetInactividad();
    }
    else if (Mathf.Approximately(rb.velocity.sqrMagnitude, 0f))
    {
        tiempoInactividad -= Time.deltaTime;
        if (tiempoInactividad <= 0f)
        {
            MoverObjeto();
        }
    }
}

private void MoverObjeto()
{
    direccion = GenerarDireccionAleatoria();
    rb.AddForce(direccion * fuerzaRebote, ForceMode2D.Impulse);
    rb.velocity = direccion * velocidad;
}

private Vector2 GenerarDireccionAleatoria()
{
    return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
}

private void ResetInactividad()
{
    tiempoInactividad = 5f;
}
}