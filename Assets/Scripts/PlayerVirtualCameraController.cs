using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVirtualCameraController : MonoBehaviour
{
    [SerializeField]private List<CinemachineVirtualCamera> cameras;

    private void Start()
    {
        SwitchCamera(0);
    }

    private void SwitchCamera(int currentCamera)
    {
        foreach (CinemachineVirtualCamera camera in cameras)
        {
            camera.Priority = 0;
        }
        cameras[currentCamera].Priority = 1;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SwitchCameraTrigger"))
        {
            SwitchCamera(collision.GetComponent<SwitchCameraTrigger>().InCameraIndex);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SwitchCameraTrigger"))
        {
            SwitchCamera(collision.GetComponent<SwitchCameraTrigger>().OutCameraIndex);
        }
    }
}
