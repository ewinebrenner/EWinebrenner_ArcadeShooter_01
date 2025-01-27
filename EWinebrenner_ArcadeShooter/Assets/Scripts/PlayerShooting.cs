using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    public float bulletSpeed = 60.0f;
    public Transform bulletSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Shoot"))
        {
            Debug.Log("Shoot");
            Rigidbody2D bulletRB = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            //Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            //bulletRB.velocity = new Vector2(0, bulletSpeed);
            //bulletRB.velocity = Vector2.up * bulletSpeed; //World Up
            bulletRB.velocity = bulletSpawn.up * bulletSpeed; //Local Up
            Destroy(bulletRB.gameObject, 1.0f);
        }
    }
}
