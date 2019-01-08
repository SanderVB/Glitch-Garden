using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    [SerializeField] float loadDelay = 3f;
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitAndLoadGameScene());
        }
    }

    IEnumerator WaitAndLoadGameScene()
    {
        yield return new WaitForSeconds(loadDelay);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

 /*   public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Screen");
    }*/

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }
    
    public void LoadOptions()
    {
        SceneManager.LoadScene("Options Screen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
