using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    public Transform pivot;

    private void Start()
    {
        Input.gyro.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot.position, pivot.up, 0.5f * Input.gyro.rotationRateUnbiased.y);
        transform.RotateAround(pivot.position, transform.right, 0.5f * Input.gyro.rotationRateUnbiased.x);
        transform.position = pivot.position - transform.forward * 10f;
    }
}
