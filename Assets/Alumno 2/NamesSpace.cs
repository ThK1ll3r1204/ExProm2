using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamesSpace : MonoBehaviour
{
    public GameObject name1;
    public GameObject name2;
    public GameObject name3;
    public GameObject name4;
    public GameObject name5;

    public float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 3.5f)
        {
            name1.SetActive(true);
            name2.SetActive(false);
            name3.SetActive(false);
            name4.SetActive(false);
            name5.SetActive(false);
        }

        if (timer >= 3.5f & timer <=7f)
        {
            name2.SetActive(true);
            name1.SetActive(false);
            name3.SetActive(false);
            name4.SetActive(false);
            name5.SetActive(false);
        }

        if (timer >= 7f & timer <= 10.5f)
        {
            name3.SetActive(true);
            name2.SetActive(false);
            name1.SetActive(false);
            name4.SetActive(false);
            name5.SetActive(false);
        }

        if (timer >= 10.5f & timer <= 14f)
        {
            name4.SetActive(true);
            name2.SetActive(false);
            name3.SetActive(false);
            name1.SetActive(false);
            name5.SetActive(false);
        }

        if (timer >= 14f & timer <= 17.5f)
        {
            name5.SetActive(true);
            name2.SetActive(false);
            name3.SetActive(false);
            name4.SetActive(false);
            name1.SetActive(false);
            timer = -1;
        }
    }
}
