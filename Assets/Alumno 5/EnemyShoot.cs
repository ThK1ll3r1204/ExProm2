using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyBullet;
    public float TimeA;
    public float TimeB;

    private int lastDir;

    public float bSpeed;

    public bool playerdetect;
    public LayerMask PlayerLayer;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        Trap2shooting();
        TimeA += Time.deltaTime;
    }

    void Trap2shooting()
    {
        playerdetect = Physics2D.OverlapCircle(transform.position, distance, PlayerLayer);
        if (playerdetect && TimeA > TimeB)
        {
            Vector3 direction = transform.position - player.transform.position;
            GameObject bullet = Instantiate(enemyBullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = direction.normalized * bSpeed;
            TimeA = 0;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, distance);
    }
}
