using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float damage;
    //[SerializeField] private GameObject Explosion;

    private void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
    }

    private void Start()
    {
        Destroy(gameObject, 2);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //collision.GetComponent<Enemy>().TakeDamage(damage);
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

        //IEnumerator Explotion()
        //{
        //    Explosion.gameObject.SetActive(true);
        //    yield return new WaitForSeconds(6);
        //    Explosion.gameObject.SetActive(false);
        //}

        //if (collision.gameObject.CompareTag("Enemy2"))
        //{
        //    collision.GetComponent<ShootAI>().TakeDamage(damage);
        //    Destroy(gameObject);
        //}
    }
}
