using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 10f);
    }
}
