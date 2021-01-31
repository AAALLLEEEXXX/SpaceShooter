using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiEnemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;

    [SerializeField]
    private float _damage = 1f;

    [SerializeField]
    private float _minDistance = 1.0f;

    [SerializeField]
    private float _maxDistance = 10.0f;

    private float _distance;
    private Transform _target;

    private void Start()
    {
        _target = FindObjectOfType<PlayerCharacter>().transform;
    }

    private void Update()
    {
        _distance = Vector3.Distance(transform.position, _target.position);

        if (_distance > _maxDistance)
            transform.Translate(0, 0, _speed * Time.deltaTime);

        if(_distance < _maxDistance && _distance > _minDistance)
        {
            transform.rotation = Quaternion.Slerp(transform.localRotation, Quaternion.LookRotation(_target.position - transform.position), _speed * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
        }
    }
}
