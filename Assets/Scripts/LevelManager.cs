using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    void Start()
    {
        if (autoLoadNextLevelAfter != 0)
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }


    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        SceneManager.LoadScene(name);
    }

    public void LoadNextLevel()
    {
        int nextLevel = CurrentLevel().buildIndex + 1;
        SceneManager.LoadScene(nextLevel);
        Debug.Log("New Level load: " + nextLevel);
    }

    public void LoadPreviousLevel()
    {
        int previousLevel = CurrentLevel().buildIndex - 1;
        SceneManager.LoadScene(previousLevel);
        Debug.Log("New Level load: " + previousLevel);
    }

    public Scene CurrentLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        return scene;
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

}
