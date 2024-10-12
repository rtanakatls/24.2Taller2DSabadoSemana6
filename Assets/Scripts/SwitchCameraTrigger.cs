using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameraTrigger : MonoBehaviour
{
    [SerializeField] private int inCameraIndex;
    [SerializeField] private int outCameraIndex;

    public int InCameraIndex { get { return inCameraIndex; } } 
    public int OutCameraIndex { get { return outCameraIndex; } }
}
