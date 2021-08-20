using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class shooky_movement : MonoBehaviour
{
    public float movespeed = 3f;
    float velX;
    float velY;
    bool facingRight = true;
    Rigidbody2D rigbody;
    public bool isGrounded = true;
    public Animator animator;

    void Start()
    {
        rigbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        velX = Input.GetAxisRaw("Horizontal");
        velY = GetComponent<Rigidbody2D>().velocity.y;
        rigbody.velocity = new Vector2(velX * movespeed, velY);
        animator.SetFloat("speed", Mathf.Abs(velX));
    }

    void LateUpdate()
    {
        Vector3 localScale = transform.localScale;
        if (velX > 0)
        {
            facingRight = true;
        }else if (velX < 0)
        {
            facingRight = false;
        }
        if(((facingRight)&&(localScale.x<0)) ||((!facingRight)&& localScale.x > 0))
        {
            localScale.x *= -1;
        }
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 9f), ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
        }
        transform.localScale = localScale;
    }
}
