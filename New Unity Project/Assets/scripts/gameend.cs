﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

//[RequireComponent (typeof(AudioSource))]

public class gameend : MonoBehaviour
{
 
    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;

    void Start()
    {
      
    }
    public void PlayV()
    {
        StartCoroutine(PlayVideo());
    }

    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while(!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
        audioSource.Play();

    }
}
