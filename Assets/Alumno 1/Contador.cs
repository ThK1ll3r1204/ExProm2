using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public TextMesh textocreditos;
    public Text textonivel1;
    public Text textonivel2;
    public Text textonivel3;
    private int contadorcreditos;
    private int contadornivel1;
    private int contadornivel2;
    private int contadornivel3;

    private void Start()
    {
        contadorcreditos = 0;
        contadornivel1 = 0;
        contadornivel2 = 0;
        contadornivel3 = 0; 
    }
    private void Update()
    {
        textocreditos.text = "Créditos" + contadorcreditos.ToString();
        textonivel1.text = "Nivel 1" + contadornivel1.ToString();
        textonivel2.text = "Nivel 2" + contadornivel2.ToString();
        textonivel3.text = "Nivel 3" + contadornivel3.ToString();
    }
    public void Mayorcreditos()
    {
        contadorcreditos++; 
    }
    public void Mayornivel1()
    {
        contadornivel1++;
    }
    public void Mayornivel2()
    {
        contadornivel2++;
    }
    public void Mayornivel3()
    {
        contadornivel3++;
    }
}
