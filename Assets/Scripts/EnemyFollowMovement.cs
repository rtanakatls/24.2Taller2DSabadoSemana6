 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;
    private Transform target;
    [SerializeField] private float minFollowDistance;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (target != null)
        {
            if (Vector2.Distance(transform.position, target.position) <= minFollowDistance)
            {
                rb2d.velocity = Vector2.zero;
            }
            else
            {
                Vector2 direction = target.position - transform.position;
                rb2d.velocity = direction.normalized * speed;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, minFollowDistance);
    }
}
