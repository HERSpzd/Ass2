using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nevigation : MonoBehaviour
{
    public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadMyscene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
