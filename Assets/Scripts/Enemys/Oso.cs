using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Oso : MonoBehaviour
{

    public GameObject zonaexplosion;
    private GameObject player;
    public AudioSource Daño;
    SpriteRenderer spriteRenderer;

    [SerializeField] private float vida;
    [SerializeField] private float daño;
    private bool isFacingRight = true;
    private GameObject jugador;
    private NavMeshAgent AGENTE;
    private Animator animator;
    public AudioSource explocion;
    public float explosion;

    public Rigidbody2D rb;

    

    bool cercaJugador = false;


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
            animator.Play("Oso Corriendo");
            
        }
        else if (!cercaJugador)
        {
            animator.Play("Oso Idle");
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
            spriteRenderer.flipX = !isFacingRight;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cercaJugador = true;
            StartCoroutine(OSO());
            Debug.Log("Toco jugador");
        }

        if (collision.CompareTag("Bala"))
        {
            TomarDaño();
            Daño.Play();
        }
    }


    IEnumerator OSO ()
    {
        AGENTE.speed = 0;
        animator.Play("Oso Estallando");

        yield return new WaitForSeconds(2);

        zonaexplosion.SetActive(true);

        animator.Play("Explosion");
        explocion.Play();

        yield return new WaitForSeconds(explosion);

        rb.velocity = Vector3.zero;
        rb.angularDrag = 0;

        Destroy(gameObject);
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
