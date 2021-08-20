using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class pointsManager : MonoBehaviour
{

    //[SerializeField] private Image fullHeart=null;
    //public Sprite sprite1;
    //public GameObject Img;
    public static int score;
    //private UnityEngine.UI.Image Img;

    void Start()
    {
        score = 0;
        //Img = GetComponent<Image>();
    }
    void Update()
    {
        if (score < 0)
        {
            score = 0;
        }
    }
    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        //Img.GetComponent<Renderer>().enabled = false;
        //GetComponent<Image>().sprite = sprite1;
        //fullHeart.enabled = true;
    }
    public static void Reset()
    {
        score = 0;
    }
}
