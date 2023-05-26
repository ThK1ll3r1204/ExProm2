using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MeterTxT : MonoBehaviour
{
    public Transform player;
    public Text textComponent;
    private float counter = 0;

    private void Start()
    {
        // Obtener la referencia al componente de texto
        textComponent = GetComponent<Text>();
    }

    private void Update()
    {
        // Aumentar el contador mientras te mueves
        if (Input.GetKey(KeyCode.W))
        {
            counter = player.transform.position.y;
            textComponent.text = "Contador: " + counter.ToString();

        }
    }
}
