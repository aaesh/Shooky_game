using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasueGane : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pausesound;
    public string Level;
    public string Main;
    //void Update()
    //{


    //    if (Input.GetButtonDown("Cancel"))
    //    {
    //        if (gamePaused == false)
    //        {
    //            pausesound.Play();
    //            Time.timeScale = 0;
    //            gamePaused = true;
    //            Cursor.visible = true;
    //            levelMusic.Pause();
    //            pauseMenu.SetActive(true);
    //        }
    //        else
    //        {
    //            pauseMenu.SetActive(false);
    //            levelMusic.UnPause();
    //            Cursor.visible = false;
    //            gamePaused = false;
    //            Time.timeScale = 1;
    //        }
    //    }
    //}

    public void pause()
    {
        if (gamePaused == false)
        {
            pausesound.Play();
            Time.timeScale = 0;
            gamePaused = true;
            //Cursor.visible = true;
            levelMusic.Pause();
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
            pausesound.Stop();
            levelMusic.UnPause();
            //Cursor.visible = false;
            gamePaused = false;
            Time.timeScale = 1;
        }
    }
    public void resume()
    {
        pauseMenu.SetActive(false);
        pausesound.Stop();
        levelMusic.UnPause();
        //Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;

    }
    public void restart()
    {
        pauseMenu.SetActive(false);
        pausesound.Stop();
        levelMusic.UnPause();
        //Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(Level);
    }
    public void quittomenu()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(Main);

    }
}
