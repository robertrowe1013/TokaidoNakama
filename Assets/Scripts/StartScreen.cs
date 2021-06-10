using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    // Start game with previous settings or go to settings screen if no settings
    public void StartGame()
    {
        if (PlayerPrefs.HasKey("PlayerCount"))
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    public void LoadSettingsScreen()
    {
        SceneManager.LoadScene(1);
    }
}
