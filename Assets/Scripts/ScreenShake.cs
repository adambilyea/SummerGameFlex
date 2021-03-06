﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public float shakeStrength = 5;
    public float shake = 1;

    Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            shake = shakeStrength;
            Debug.Log("Shake Enabled");
        }

        gameObject.transform.localPosition = originalPosition + (Random.insideUnitSphere * shake);

        shake = Mathf.MoveTowards(shake, 0, Time.deltaTime * shakeStrength);

        if (shake == 0)
        {
            gameObject.transform.localPosition = originalPosition;
        }
    }
}