using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotation : MonoBehaviour
{

    int rotationOffset = 0;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + rotationOffset);

        if (Input.GetAxis("Horizontal") < 0)
        {
            rotationOffset = 180;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            rotationOffset = 0;
        }
    }
}
