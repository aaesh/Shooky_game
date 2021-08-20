using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyFinishedParticles : MonoBehaviour
{
    private ParticleSystem thisparticleSystem;
    void Start()
    {
        thisparticleSystem = GetComponent<ParticleSystem>();
    }

    
    void Update()
    {
        if (thisparticleSystem.isPlaying)
        {
            return;
        }

        Destroy(gameObject);
    }
}
