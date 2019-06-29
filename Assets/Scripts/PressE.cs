using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressE : MonoBehaviour
{
    private bool inTrigger;
    public static bool activated = false;
    public GameObject deathEffect;
    GameObject clone;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = false;
        }
    }

    void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Activated");
            activated = true;
        }
    }




}
