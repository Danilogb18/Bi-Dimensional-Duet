using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    int rotation;
    
    [SerializeField]
    int direction;

    [SerializeField]
    int timeToShoot;

    public GameObject bulletPrefab;

    bool canShoot;

    void Start()
    {
        canShoot = true;
    }

    
    void Update()
    {
        if (canShoot)
        {
            canShoot = false;
            Invoke("InstantiateBullet", timeToShoot);
        }
    }


    public void InstantiateBullet()
    {
        canShoot = true;
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bulletPrefab.GetComponent<Bullet>().SetDirection(direction, rotation);
    }


}
