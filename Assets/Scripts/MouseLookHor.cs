using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookHor : MonoBehaviour
{
    private float _sensitivityHor = 9.0f;

    
    private void Update()
    {  
        transform.Rotate(0, Input.GetAxis("Mouse X") * _sensitivityHor, 0);
    }
}
