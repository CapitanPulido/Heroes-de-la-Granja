using System.Buffers;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Puligod : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float speedbase;
    [SerializeField] private float speedxtra;
    [SerializeField] private float sprinttime;
    [SerializeField] private float EstaminaMaxima;
    [SerializeField] private float Sanacion;

    [SerializeField] private float vida;
    [SerializeField] private float vidaMaxima;
    [SerializeField] private float daño;
    [SerializeField] private Barradevida barradevida;
    [SerializeField] private BarradeEstamina barradeEstamina;
    [SerializeField] private float Sprint;

    public bool puedocorrer = true;
    public bool estacorriendo = false;

    private float tiempoactualSprint;
    private float tiempoSiguienteSprint;

    [SerializeField] private float tiempoEntreSprints;

    private bool isFacingRight = true;
    private Vector2 input;
    private Rigidbody2D rb;
    private Animator animator;
    private Slider slider;
    public Disparo disparo;
    public AudioSource Daño;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        vida = vidaMaxima;
        sprinttime = EstaminaMaxima;
        barradevida.InicializarBarradeVida(vida);
        barradeEstamina.InicializarBarradeEstamina(sprinttime);
        tiempoactualSprint = sprinttime;


    }

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        input = new Vector2(xInput, yInput).normalized;

        barradeEstamina.CambiarEstaminaActual(tiempoactualSprint);


        if (xInput != 0 || yInput != 0)
        {


            animator.Play("Pulido corriendo");
            Flip();
        }
        else
        {
            animator.Play("Idle pulido");
        }

        if (Input.GetButton("Fire1"))
        {
            animator.Play("Idle pulido");
        }

        //Sprint

        if (Input.GetKeyDown(KeyCode.LeftShift) && puedocorrer)
        {
            speed = speedxtra;
            estacorriendo = true;

        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speedbase;
            estacorriendo = false;

        }

        if (xInput != 0 || yInput != 0 && estacorriendo)
        {
            if (tiempoactualSprint > 0)
            {
                tiempoactualSprint -= Time.deltaTime;
            }
            else
            {
                speed = speedbase;
                estacorriendo = false;
                puedocorrer = false;
                tiempoSiguienteSprint = Time.deltaTime + tiempoEntreSprints;
            }
        }


        if (!estacorriendo && tiempoactualSprint <= sprinttime && Time.time >= tiempoSiguienteSprint)
        {
            tiempoactualSprint += Time.deltaTime;
            if (tiempoactualSprint >= sprinttime)
            {
                puedocorrer = true;
            }
        }

        //Prueba de daño

        //if (Input.GetKeyDown(KeyCode.H))
        //{
        //    TomarDaño();
        //}



    }



    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime);
    }

    private void Flip()
    {

        if ((input.x < 0 && isFacingRight) || (input.x > 0 && !isFacingRight))
        {
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }

    public void TomarDaño()
    {
        vida -= daño;
        barradevida.CambiarVidaActual(vida);

        if (vida <= 0)
        {
            SceneManager.LoadScene("MenuDerrota");
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Explosion"))
        {
            TomarDaño();
            Daño.Play();
        }

        if (collision.gameObject.CompareTag("Bala1"))
        {
            TomarDaño();
            Daño.Play();
        }

        if (collision.gameObject.CompareTag("Medkit"))
        {
            Curar();
        }

        if (collision.gameObject.CompareTag("Municion"))
        {
            Destroy(collision.gameObject);
            disparo.MunicionMas();
        }
    }

    public void Curar()
    {
        vida += Sanacion;
        barradevida.CambiarVidaActual(vida);
    }
}
