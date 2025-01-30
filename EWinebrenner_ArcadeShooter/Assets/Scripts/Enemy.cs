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

            //Add score
            //FindObjectOfType
            //FindObjectOfType<GameManager>().score += 10;

            ////Gameobject.find
            //GameObject gmo = GameObject.Find("GameManager");
            //if (gmo != null)
            //{
            //    GameManager gm = gmo.GetComponent<GameManager>();
            //    if (gm != null)
            //    {
            //        gm.score += 10;
            //    }
            //}

            GameManager.Score += 10;
            //GameManager.Score = 0; 
        }
    }
}
