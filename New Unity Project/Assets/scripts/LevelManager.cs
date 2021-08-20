using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    private shooky_movement player;
    public GameObject deathparticle;
    public GameObject RespawnParticle;
    public float respawndelay;
    public AudioSource dead;
    void Start()
    {
        player = FindObjectOfType<shooky_movement>();
    }

    void Update()
    {
        
    }
    public void RespawmPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(deathparticle, player.transform.position, player.transform.rotation);//this will creayte a copy of object
        //to stop plyer movement when dead and to not able to view
        dead.Play();
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        yield return new WaitForSeconds(respawndelay); //create a delay
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        Instantiate(RespawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
    }
}
