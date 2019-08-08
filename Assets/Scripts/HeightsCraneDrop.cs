using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightsCraneDrop : MonoBehaviour
{
    public static bool activated = false;
    bool inTrigger = false;
    bool in2ndTrigger = false;
    private GameObject BreakableFloor;

    public GameObject AddingTheSecondTrigger;
    GameObject clone;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MaxHeight")
        {
            inTrigger = true;
            clone = (GameObject)Instantiate(AddingTheSecondTrigger, new Vector3(198.6369f, 35.77398f, 0f), Quaternion.identity);
            Debug.Log("High");
        }

        else if (other.gameObject.tag == "BreakableFloor")
        {
            in2ndTrigger = true;
            Debug.Log("BOOM");
        }
    }

    void Update()
    {
        if (inTrigger == true && in2ndTrigger == true)
        {
            activated = true;
            BreakableFloor = GameObject.FindGameObjectWithTag("BreakableFloor");
            DestroyObject(BreakableFloor);
        }
    }

}
