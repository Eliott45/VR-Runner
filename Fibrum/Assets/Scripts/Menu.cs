using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void toMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
