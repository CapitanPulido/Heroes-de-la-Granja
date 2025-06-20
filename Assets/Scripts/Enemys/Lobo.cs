using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.AI;


public class Lobo : MonoBehaviour
{

    private GameObject player;
    public AudioSource Da�o;
    SpriteRenderer spriteRenderer;

    [SerializeField] private float vida;
    [SerializeField] private float da�o;
    private bool isFacingRight = true;
    private GameObject jugador;
    private NavMeshAgent AGENTE;
    private Animator animator;

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
        if(player != null)
        {
            bool isPlayerRight = transform.position.x < player.transform.position.x;

            Flip(isPlayerRight);
            AGENTE.SetDestination(jugador.transform.position);
        }

        if (AGENTE.speed > 0)
        {
            animator.Play("Lobo corriendo");

        }
        //else
        //{
        //    animator.Play("Idle Mapache");
        //}

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
            spriteRenderer.flipX = !isFacingRight;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Bala"))
        {
            TomarDa�o();
            Da�o.Play();
        }
    }


    public void TomarDa�o()
    {
        vida -= da�o;


        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }




}
