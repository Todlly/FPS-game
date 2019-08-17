using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    GameObject player;
    private float mouseX, mouseY;
    public float sensitivity = 150.0f;
    private float yTracker;

    void Start()
    {
        player = transform.parent.gameObject;
        Cursor.lockState = CursorLockMode.Locked;
        yTracker = 0.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        MouseMove();
    }

    void MouseMove()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        yTracker += mouseY;

        if (yTracker > 90.0f)
        {
            yTracker = 90.0f;
            mouseY = 0.0f;
            CorrectCam(-90.0f);
        }
        else if (yTracker < -90.0f)
        {
            yTracker = -90.0f;
            mouseY = 0.0f;
            CorrectCam(90.0f);
        }
        transform.Rotate(Vector3.left, mouseY);
        this.transform.parent.transform.Rotate(Vector3.up, mouseX);
    }

    void CorrectCam(float value)
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.x = value;
        transform.eulerAngles = rotation;
    }

}
