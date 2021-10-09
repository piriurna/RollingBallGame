using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private GameObject followRb;

    [SerializeField] private Vector3 offset;

    [SerializeField] private Vector3 RotationOffset;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = followRb.transform.position + offset;
    }
}
