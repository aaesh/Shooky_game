using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class milk_movement : MonoBehaviour
{
    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;
    void Start()
    {
        
    }

    
    void Update()
    {
        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        if (hittingWall)
        {
            moveRight = !moveRight;
        }

        if (moveRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        //if (moveRight)
        //{
        //    transform.Translate(2 * Time.deltaTime * moveSpeed, 0, 0);
        //    transform.localScale = new Vector2(1, 1);
        //}
        //else
        //{
        //    transform.Translate(-2 * Time.deltaTime * moveSpeed, 0, 0);
        //    transform.localScale = new Vector2(-1, 1);
        //}
    }

    //void OnTriggerEnter2D(Collider2D trig)
    //{
    //    if (trig.gameObject.name == "milk_turn")
    //    {
    //        if (moveRight)
    //        {
    //            moveRight = false;
    //        }
    //        else
    //        {
    //            moveRight = true;
    //        }
    //    }
    //}
}
