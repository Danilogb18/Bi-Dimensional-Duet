using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform target;
    public int angle;
    Vector3 rotation;
    public Vector3 playerPosition;


    [SerializeField]
    int bulletSpeed;

    bool canShoot;


    int whereToGo;


    public float rotationOfBullet;

    void Start()
    {

    }
    
    
    void FixedUpdate()
    {
        transform.Translate(0,-5,0);
        
    }


    public void SetDirection (int direction, int rotation)
    {
        rotationOfBullet = rotation;
        whereToGo = direction;

    }


}
