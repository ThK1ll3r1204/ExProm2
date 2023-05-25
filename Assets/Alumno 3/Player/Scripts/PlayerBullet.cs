using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    Rigidbody2D bRb;
    [SerializeField] float maxLifeSpan;
    float lifeSpanTime;
    public int bDamage;
    void Awake()
    {
        bRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        lifeSpanTime += Time.deltaTime;

        if (lifeSpanTime >= maxLifeSpan)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            Destroy(gameObject);
    }
}
