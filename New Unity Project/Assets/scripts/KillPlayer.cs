using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public LevelManager levelManager;
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();//this finds any object in scene that is from level manager
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "shooky")
        {
            levelManager.RespawmPlayer();
        }
    }
}
