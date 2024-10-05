using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletFollowMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;
    private Transform target;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (target != null)
        {
            Vector2 direction = target.position - transform.position;
            rb2d.velocity = direction.normalized * speed;
        }
    }
}
