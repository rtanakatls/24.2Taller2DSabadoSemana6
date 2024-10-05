using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private float timer;
    [SerializeField] private float shootTimeDelay;
    [SerializeField] private GameObject bulletPrefab;
    private Transform target;

    [SerializeField] private float shootingRange;

    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }


    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (target != null)
        {
            if (Vector2.Distance(transform.position, target.position) <= shootingRange)
            {
                timer += Time.deltaTime;
                if (timer >= shootTimeDelay)
                {
                    Vector2 targetPosition = target.position;
                    Vector2 originPosition = transform.position;
                    targetPosition.x += Random.Range(-1.5f, 1.5f);
                    targetPosition.y += Random.Range(-1.5f, 1.5f);
                    Vector2 direction = targetPosition - originPosition;
                    direction = direction.normalized;
                    GameObject obj = Instantiate(bulletPrefab);
                    obj.transform.position = transform.position;
                    obj.GetComponent<BulletMovement>().SetDirection(direction);
                    timer = 0;
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}
