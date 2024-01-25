using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_play : MonoBehaviour
{
    public void LoadSceneOne()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadSceneTwo()
    {
        SceneManager.LoadScene(1);
    }
}