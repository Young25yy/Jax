using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    public Transform viewTarget;
    public Transform viewCameraTrans;
    public float distance = 5f;
    public float minDistance = 1f;
    public float maxDistance = 10f;
    public float rotateSpeed = 200f;
    public float zoomSpeed = 5f;
    private float yaw;
    private float pitch;
    void Start()
    {
        viewCameraTrans = Camera.main.transform;
        yaw = viewTarget.eulerAngles.y;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
        pitch = Mathf.Clamp(pitch, -Mathf.Atan2(1.5f, distance) * Mathf.Rad2Deg + 5f, 80f);
        // pitch = Mathf.Clamp(pitch, -15f, 80f);
        distance -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0f);
        viewCameraTrans.position = viewTarget.position - rotation * Vector3.forward * distance;
        viewCameraTrans.rotation = rotation;
    }
}
