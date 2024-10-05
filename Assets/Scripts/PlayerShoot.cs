using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private float timer;
    [SerializeField] private float shootTimeDelay;
    [SerializeField] private GameObject bulletPrefab;
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;
    }


    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        timer += Time.deltaTime;
        if (Input.GetMouseButton(0) && timer >= shootTimeDelay)
        {
            Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 originPosition = transform.position;
            Vector2 direction = mousePosition - originPosition;
            direction = direction.normalized;
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(direction);
            timer = 0;
        }
    }
}
