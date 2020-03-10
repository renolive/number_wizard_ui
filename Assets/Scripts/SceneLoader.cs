using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene(){
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((currenSceneIndex+1)%SceneManager.sceneCountInBuildSettings);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
