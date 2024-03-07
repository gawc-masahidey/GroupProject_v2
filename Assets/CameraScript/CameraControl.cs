using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
  
    [SerializeField] float keyboardInputSensitivity = 1f;
    Vector3 input;


    private void Update()
    {
        MoveCameraInput();
        MoveCamera();
  
    }

    private void MoveCamera()
    {
        transform.position += (input * Time.deltaTime);
    }

    private void MoveCameraInput()
    {
        AxisInput();
    }

    private void AxisInput()
    {
        input.x = Input.GetAxisRaw("Horizontal") * keyboardInputSensitivity;
        input.z = Input.GetAxisRaw("Vertical") * keyboardInputSensitivity;
    }
}
