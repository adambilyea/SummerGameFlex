using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    float counter;

    bool isJumping;
    bool isCrouch = false;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            Flip();
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            Flip();
        }
        transform.localScale = characterScale;

        Jump();

    }

    private void Flip()
    {
        counter++;
        if (counter == 1)
            transform.Rotate(0f, 180f, 0f);
        else
            counter = 0;


    }

    void Jump()
    {
        if (Input.GetKeyDown (KeyCode.Space) && !isJumping)
        {
            isJumping = true;

            rb.AddForce(new Vector2(rb.velocity.x , jumpForce));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;

            
        }
    }
}
