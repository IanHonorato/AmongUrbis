using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public bool mouseIsLocked = true;
    public float sensitivity = 2.0f;
    

    private float mouseX = 0.0f, mouseY = 0.0f;
    void Start()
    {
        if (!mouseIsLocked)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            //return;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity;

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
