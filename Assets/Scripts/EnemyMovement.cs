using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;
    private float timer;
    [SerializeField] private float changeDirectionDelay;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ChangeDirection();
        Move();
    }

    private void ChangeDirection()
    {
        timer += Time.deltaTime;
        if (timer >= changeDirectionDelay)
        {
            direction *= -1;
            timer = 0;
        }
    }

    private void Move()
    {
        rb2d.velocity = direction.normalized * speed;
    }

}
