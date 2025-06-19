using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala1 : MonoBehaviour
{
   

    private void Update()
    {
       
    }

    private void Start()
    {
        Destroy(gameObject, 2);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Destroy(gameObject);
            //StartCoroutine(Explotion());
        }

        if (collision.gameObject.CompareTag("muro"))
        {
            Destroy(gameObject);
            //StartCoroutine(Explotion());
        }

        else
        {
            
        }

       
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("muro"))
        {
            Destroy(gameObject);
            //StartCoroutine(Explotion());
        }
    }
}
