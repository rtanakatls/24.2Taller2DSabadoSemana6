using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    private Camera cam;

    private void Awake()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }


    void Update()
    {
        Target();
    }

    private void Target()
    {
        Vector2 mousePosition= cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 originPosition = transform.position;
        transform.up=mousePosition-originPosition;
    }
}
