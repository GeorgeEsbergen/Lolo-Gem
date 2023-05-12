using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelAudio;
    public GameObject pausedMenu;
    public AudioSource pausedJingle;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                pausedJingle.Play();
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelAudio.Pause();
                pausedMenu.SetActive(true);
            }
            else

            {
                pausedJingle.Stop();
                pausedMenu.SetActive(false);
                levelAudio.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;

            }
        }
    }
    public void ResumeGame()
    {
        pausedJingle.Stop();
        pausedMenu.SetActive(false);
        levelAudio.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }
    public void RestartLevel()
    {
        pausedJingle.Stop();
        pausedMenu.SetActive(false);
        levelAudio.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        pausedJingle.Stop();
        pausedMenu.SetActive(false);
        levelAudio.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
