using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Rigidbody2D rb;

    void Start()
    {
        
    
        player = FindObjectOfType<Gallo>().transform;
        player = FindObjectOfType<Cerdo>().transform;
        rb = GetComponent<Rigidbody2D>();

        Shoot();
    }

    public void Update()
    {
        
    }

    public void Shoot()
    {

        Vector2 directionToPlayer = (player.position - transform.position).normalized;
        rb.velocity = directionToPlayer * speed;
    }
}
