using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
            Invoke("Shoot", .4f);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Shoot();
            Invoke("Shoot", .4f);
            Invoke("Shoot", .8f);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Shoot();
            Invoke("Shoot", .4f);
            Invoke("Shoot", .8f);
            Invoke("Shoot", 1.2f);
        }
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", .3f);
        }
    }

    private void ResetShoot()
    {
        canShoot = true;
    }
}
