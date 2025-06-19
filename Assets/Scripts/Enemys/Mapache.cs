using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mapache : MonoBehaviour
{
    private GameObject player;
    public AudioSource Daño;
    SpriteRenderer spriteRenderer;

    [SerializeField] private float vida;
    [SerializeField] private float daño;
    private bool isFacingRight = true;
    private GameObject jugador;
    private NavMeshAgent AGENTE;
    private Animator animator;

    public float damage;
    

    public Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        jugador = GameObject.FindGameObjectWithTag("Player");
        AGENTE = GetComponent<NavMeshAgent>();

        AGENTE.updateRotation = false;
        AGENTE.updateUpAxis = false;

        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }


    void Update()
    {
        if (jugador != null)
        {
            bool isPlayerRight = transform.position.x < player.transform.position.x;

            Flip(isPlayerRight);
            AGENTE.SetDestination(jugador.transform.position);
        }


        if (AGENTE.speed > 0)
        {
            animator.Play("Mapache Corriendo");

        }
        else 
        {
            animator.Play("Idle Mapache");
        }

        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    Destroy(gameObject);
        //}
    }

    private void Flip(bool isPlayerRight)
    {
        if ((isFacingRight && !isPlayerRight) || (!isFacingRight && isPlayerRight))
        {
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 

        if (collision.CompareTag("Bala"))
        {
            TomarDaño();
            Daño.Play();
        }
    }


    public void TomarDaño()
    {
        vida -= daño;


        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

}
