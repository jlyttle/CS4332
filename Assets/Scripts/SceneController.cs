using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void start_button_scene()
    {
        Application.LoadLevel("Map1");
    }

    public void end_button_scene()
    {
        Application.Quit();
    }
}
