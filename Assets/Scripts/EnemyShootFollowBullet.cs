using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootFollowBullet : MonoBehaviour
{
    private float timer;
    [SerializeField] private float shootTimeDelay;
    [SerializeField] private GameObject bulletPrefab;
    private Transform target;

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
            timer += Time.deltaTime;
            if (timer >= shootTimeDelay)
            {
                GameObject obj = Instantiate(bulletPrefab);
                obj.transform.position = transform.position;
                obj.GetComponent<EnemyBulletFollowMovement>().SetTarget(target);
                timer = 0;
            }
        }
    }
}
