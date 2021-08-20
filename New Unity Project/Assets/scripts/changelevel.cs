using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changelevel : MonoBehaviour
{
    public int index;
    public string levelName;
    public GameObject EndLevelParticle;
    public GameObject RespawnParticle;
    private shooky_movement player;
    public float respawndelay;
    public gameend Gd;
    public AudioSource pickup;
    public AudioSource levelMusic;
    public GameObject rawImage;

    void Start()
    {
        player = FindObjectOfType<shooky_movement>();
        Gd = FindObjectOfType<gameend>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "shooky")
        {
            //Loading level with build index
            //SceneManager.LoadScene(1);
            //SceneManager.LoadScene(index);
            StartCoroutine("RespawnPlayerCo");

        }
    }
    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(EndLevelParticle, player.transform.position, player.transform.rotation);//this will creayte a copy of object
        //to stop plyer movement when dead and to not able to view
        //player.enabled = false;
        //player.GetComponent<Renderer>().enabled = false;
        pickup.Play();
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        yield return new WaitForSeconds(respawndelay);//create a delay

        if (levelName == "MainM")
        {
            rawImage.SetActive(true);
            levelMusic.Pause();
            Gd.PlayV();
            respawndelay = 31;
            yield return new WaitForSeconds(respawndelay);
            rawImage.SetActive(false);
        }
        SceneManager.LoadScene(levelName);
        //player.enabled = true;
        //player.GetComponent<Renderer>().enabled = true;
    }
}
