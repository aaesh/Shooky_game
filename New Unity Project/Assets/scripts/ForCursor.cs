using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ForCursor : MonoBehaviour
{
    public string play;
    void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
    }

    public void Play()
    {
        SceneManager.LoadScene(play);
    }

    public void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
