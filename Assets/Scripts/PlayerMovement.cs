using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    private float inputVertical;
    private Rigidbody2D rb;
    public float distance;
    public LayerMask whatIsLadder;
    private bool isClimbing;
    public float ladderSpeed = 1f;
    public float thrust;
    public float speed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    public GameObject dustEffect;
    GameObject clone;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    //get input from player
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bouncy")
        {
            Debug.Log("Testing");
            rb.AddForce(transform.up * 560);
            // this rigidbody hit the player
        }
    }

    public void onLanding()
    {
        animator.SetBool("isJumping", false);
        //clone = (GameObject)Instantiate(dustEffect, new Vector3 (transform.position.x, transform.position.y - 1.2f, -10f), Quaternion.identity);

    }

    public void onCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);

    }

    public void onClimbing(bool isClimbing)
    {
        animator.SetBool("isClimbing", isClimbing);

    }



    void FixedUpdate()
    {
        //move our character
        //ensure we move the same amount no matter how many times function is called 
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);

        if (hitInfo.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                isClimbing = true;
                animator.SetBool("isClimbing", true);
            }
        }
        else
        {
            isClimbing = false;
            animator.SetBool("isClimbing", false);
        }

        if (isClimbing == true)
        {
            inputVertical = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, inputVertical * ladderSpeed);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 3;
            animator.SetBool("isClimbing", false);
        }
            
    }
}
