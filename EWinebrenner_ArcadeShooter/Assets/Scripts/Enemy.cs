using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit something SOLID");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit something");
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(gameObject);//Destroy self
            Destroy(collision.gameObject); //Destroy bullet object 
        }
    }
}
