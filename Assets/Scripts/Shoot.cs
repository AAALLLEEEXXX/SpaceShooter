using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private float _damage = 5.0f;

    [SerializeField]
    private float _range = 50.0f;

    private Camera _camera;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            var ray = _camera.ScreenPointToRay(point);

            if (Physics.Raycast(ray, out var hit, _range))
            {
                Debug.Log(hit.transform.name);
            }
        }
    }
}
