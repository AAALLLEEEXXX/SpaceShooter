using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    private int _health = 500;

    public void Hurt(int damage)
    {
        //_health -= damage;
        _health = _health - damage;

        if (_health <= 0)
            SceneManager.LoadScene(1);

        Debug.Log("Health: " + _health);
    }
}
