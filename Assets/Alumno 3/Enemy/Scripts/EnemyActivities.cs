using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyActivities : MonoBehaviour
{
    private Rigidbody2D eRb;
    private PlayerBullet pBullet;
    [SerializeField] float eSpeed;
    [SerializeField] int eLife;
    
    void Awake()
    {
        eRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        eRb.velocity = Vector2.down * eSpeed;

        if(eLife <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            KillPlayer();

        if (collision.CompareTag("PlayerBullet"))
        {
            pBullet = collision.gameObject.GetComponent<PlayerBullet>();
            eLife -= pBullet.bDamage;
        }

        if(collision.CompareTag("Walls"))
            Destroy(gameObject);
    }

    public void KillPlayer()
    {
        SceneManager.LoadScene(6);
    }
}
