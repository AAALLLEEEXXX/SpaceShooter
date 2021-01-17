using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 5.1f;

    private void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
