using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour
{
    [SerializeField]
    private Button _startButton;

    [SerializeField]
    private Button _settingsButton;

    [SerializeField]
    private Button _exitButton;

    private void Start()
    {
        _startButton.onClick.AddListener(ButtonStart);
        _exitButton.onClick.AddListener(ButtonExit);
    }

    private void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    private void ButtonExit()
    {
        Application.Quit();
    }
}
