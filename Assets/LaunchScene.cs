using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchScene : MonoBehaviour
{
    public void LaunchGameScene()
    {
        SceneManager.LoadScene(1);
    }
    public void Leave()
    {
        Application.Quit();
    }
}
