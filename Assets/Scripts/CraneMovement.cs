using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMovement : MonoBehaviour
{
    private PressE myScript;
    private Rigidbody2D CraneRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        CraneRigidbody = GameObject.Find("TopOfCrane").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PressE.activated == true)
        {
            transform.rotation = Quaternion.EulerAngles(0f, 0f, transform.rotation.z + 0.11f/*0.228f*/);
            transform.position = new Vector3(176.84f, 60.41f, 0f);

        }
    }
}
