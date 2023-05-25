using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float bSpeed;
    private float bCldwnTime;
    [SerializeField] float bCldwnMax;
    [SerializeField] GameObject pBullet;

    void Update()
    {

        Shooting();
    }

    private void Shooting()
    {

        if (bCldwnTime <= bCldwnMax + 1f)
            bCldwnTime += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && bCldwnTime >= bCldwnMax)
        {
            GameObject bullet = Instantiate(pBullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = bSpeed * Vector2.up;
            bCldwnTime = 0;
        }
    }
}
