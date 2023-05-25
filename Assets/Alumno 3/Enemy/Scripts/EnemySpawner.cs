using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float sCldwnMax;
    private float sCldwnTime;
    [SerializeField] GameObject enemy;
    private int yesOrNo;
    void Awake()
    {
            
    }
    void Update()
    {
        sCldwnTime += Time.deltaTime;

        
        if(sCldwnTime >= sCldwnMax)
        {
            yesOrNo = Random.Range(-1, 1);

            if (yesOrNo < 0)
            {
                GameObject eSpawned = Instantiate(enemy, transform.position, Quaternion.identity);
            }
            sCldwnTime = 0f;
        }
    }
}
