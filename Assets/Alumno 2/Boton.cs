using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    public Button button;
    public int value;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }



    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(CambioEscena);
    }

    public void CambioEscena()
    {
        SceneManager.LoadScene(value);
    }


}
