using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 camera;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPlayer = false;


    void Start()
    {
        camera = transform.position - PlayerTransform.position;
    }

    void Update()
    {
        Vector3 CameraV3 = PlayerTransform.position + camera;

        transform.position = Vector3.Slerp(transform.position, CameraV3, SmoothFactor);

        if (LookAtPlayer)
        {
            transform.LookAt(PlayerTransform);
        }

    }

}