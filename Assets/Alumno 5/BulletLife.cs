using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    void Update()
    {
        Destruction();
    }

    public void Destruction()
    {
        Destroy(gameObject, 10f);
    }
}
