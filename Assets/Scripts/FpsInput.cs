using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FpsInput : MonoBehaviour
{
    private float _speed = 7f;
    private float _gravity = -9.8f;

    private CharacterController _controller;

    private void Start()
    {
        _controller = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        var deltaX = Input.GetAxis("Horizontal") * _speed;
        var deltaZ = Input.GetAxis("Vertical") * _speed;
        var motion = new Vector3(deltaX, 0, deltaZ);
        motion = Vector3.ClampMagnitude(motion, _speed);
        motion.y = _gravity;
        motion *= Time.deltaTime;
        motion = transform.TransformDirection(motion);
        _controller.Move(motion);
    }
}
