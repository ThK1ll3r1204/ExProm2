using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;

    [SerializeField] float timer;
    [SerializeField] float maxTimer;

    [SerializeField] bool canShoot;

    [SerializeField] LayerMask playerLayer;
    [SerializeField] float radius;
    [SerializeField] float bulletSpeed;

    void Start()
    {
        firePoint = GetComponent<Transform>();
        maxTimer = 0.8f;
    }

    void Update()
    {
        canShoot = Physics2D.OverlapCircle(transform.position, radius, playerLayer);
        timer += Time.deltaTime;
        if (canShoot && timer >= maxTimer)
        {
            Shoot();
        }



    }

    void Shoot()
    {
        

        Vector2 direction = player.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(0, 0, angle);
        transform.rotation = rotation;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = direction.normalized * bulletSpeed;

        timer = 0;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
        
    }

}
