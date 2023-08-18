using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionButton : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuCanvas;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
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
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Title");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Save()
    {
        DataManager.Instance.SaveGameData();
    }
}
