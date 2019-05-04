using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Spawn : MonoBehaviour
{
    public GameObject Bullet;
    public Transform SpawnPoint;

    void FixedUpdate()
    {
        bool shoot = Input.GetButtonDown("Fire1");

         if (shoot)
         {
                Instantiate(Bullet, SpawnPoint.position, SpawnPoint.rotation);
         }
    }

}
