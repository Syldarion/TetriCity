using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Vector3 focalPoint;
    public float cameraDistance;
    public float yawAngle;
    public float pitchAngle;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = CalculatePosition();
        transform.LookAt(focalPoint);
    }

    private Vector3 CalculatePosition()
    {
        Vector3 offset = Vector3.zero;
        offset.x = cameraDistance * Mathf.Sin(yawAngle) * Mathf.Cos(pitchAngle);
        offset.y = cameraDistance * Mathf.Sin(pitchAngle);
        offset.z = cameraDistance * Mathf.Cos(yawAngle) * Mathf.Cos(pitchAngle);
        return focalPoint + offset;
    }
}
