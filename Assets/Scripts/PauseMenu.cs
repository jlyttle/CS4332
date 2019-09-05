using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause_menu;
    public static bool is_paused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (is_paused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pause_menu.SetActive(false);
        Time.timeScale = 1f;
        is_paused = false;
    }

    void Pause()
    {
        pause_menu.SetActive(true);
        Time.timeScale = 0f;
        is_paused = true;
    }

    public void Surrender()
    {
        Application.LoadLevel("Map1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
