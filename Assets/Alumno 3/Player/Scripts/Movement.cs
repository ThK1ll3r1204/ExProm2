using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D pRb;
    void Awake()
    {
        pRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 move = new Vector2(horizontal * speed, 0);
        pRb.velocity = move;
    }
}
