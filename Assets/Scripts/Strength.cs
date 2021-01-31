using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : MonoBehaviour
{
    [SerializeField]
    private float _health = 25f;

    public void Damage(float value)
    {
        _health -= value;

        if (_health <= 0)
            Destroy(gameObject);
    }
}
