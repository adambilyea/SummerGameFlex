﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 0.1f);
    }
}
