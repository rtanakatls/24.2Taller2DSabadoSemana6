using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;
    }

    private void Update()
    {

        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 originPosition = transform.position;
        Vector2 direction = mousePosition - originPosition;
        transform.up = direction;
    }
}
