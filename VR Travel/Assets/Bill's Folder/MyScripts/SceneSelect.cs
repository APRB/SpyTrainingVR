using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public string sceneToLoad;

   public void LoadNewScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
