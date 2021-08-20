using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }



    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player.GetComponent<shooky_movement>().isGrounded = true;
        Player.GetComponent<shooky_movement>().animator.SetBool("isJumping", false);
        //shooky_movement.animator.SetBool("IsJumping", false);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Player.GetComponent<shooky_movement>().isGrounded = false;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.collider.tag == "Ground")
    //    {
    //        Player.GetComponent<shooky_movement>().isGrounded = true;
    //    }
    //}
    //private void OnCollisionExit2D(Collision2D collision )
    //{
    //    if (collision.collider.tag == "Ground")
    //    {
    //        Player.GetComponent<shooky_movement>().isGrounded = false;
    //    }
    //}
}
