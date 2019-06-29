using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMovement : MonoBehaviour
{
    private PressE myScript;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PressE.activated == true)
        {
            Debug.Log("Crane Is Moving");
            rb.AddForce(transform.up * 1560);
        }
    }
}
