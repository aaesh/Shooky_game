using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startup : MonoBehaviour
{
    public float videotime=44;
    public string levelName;
    public gameend Gs;
    void Start()
    {
        Gs = FindObjectOfType<gameend>();
        StartCoroutine("PlayIntro");
    }
    public void skipIntro()
    {
        SceneManager.LoadScene(levelName);
    }
    public IEnumerator PlayIntro()
    {
        Gs.PlayV();
        yield return new WaitForSeconds(videotime);     
        SceneManager.LoadScene(levelName);
    }
}
