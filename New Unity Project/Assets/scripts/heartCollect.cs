using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heartCollect : MonoBehaviour
{
   
    public int pointsToadd;
    public Image img;
    public AudioSource pickup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<shooky_movement>() == null)
            return;
        pickup.Play();
        pointsManager.AddPoints(pointsToadd);
        img.enabled = false;
        Destroy(gameObject);
    }
}
