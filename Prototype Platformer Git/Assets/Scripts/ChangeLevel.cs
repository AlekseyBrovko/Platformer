using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public void NextLevelHandler()
    {
        Scene scene = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(scene.buildIndex + 1);        
        Debug.Log("Loading Next Level");
        Time.timeScale = 1f;
    }
}
