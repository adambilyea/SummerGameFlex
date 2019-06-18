using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightsRespawn : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DeathObject")
        {
            Debug.Log("Testing");
            rb.transform.localPosition = new Vector2(7.1f, 169f);
            // this rigidbody hit the player
        }
    }
}
