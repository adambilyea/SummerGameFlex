using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObjectHeights : MonoBehaviour
{
    private HeightsCraneDrop myScript;
    bool collidedWithPlayerFromMaxHeight = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            collidedWithPlayerFromMaxHeight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (HeightsCraneDrop.activated == true && collidedWithPlayerFromMaxHeight == true)
        {
            Destroy(gameObject);
            Debug.Log("Floor Destroyed");
        }
    }
}
