using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookVert : MonoBehaviour
{
    private float _sensitivityVert = 9.0f;

    private float _minimumVert = -45.0f;
    private float _maximumVert = 45.0f;

    private float _rotationX = 0;

    private void Update()
    {
        _rotationX -= Input.GetAxis("Mouse Y") * _sensitivityVert;
        _rotationX = Mathf.Clamp(_rotationX, _minimumVert, _maximumVert);
        var _rotationY = transform.localEulerAngles.y;
        transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
    }
}
