using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] float sCldwnMax;
    private float sCldwnTime;
    [SerializeField] GameObject cloud;
    [SerializeField] float cSpeed;
    private int yesOrNo;
    void Awake()
    {

    }
    void Update()
    {
        sCldwnTime += Time.deltaTime;

        if (sCldwnTime >= sCldwnMax)
        {
            yesOrNo = Random.Range(-1, 1);

            if (yesOrNo < 0)
            {
                GameObject cSpawned = Instantiate(cloud, transform.position, Quaternion.identity);
                cSpawned.GetComponent<Rigidbody2D>().velocity = cSpeed * Vector2.down;
            }
            sCldwnTime = 0f;
        }
    }
}

