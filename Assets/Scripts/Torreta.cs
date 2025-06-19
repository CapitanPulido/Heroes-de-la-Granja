using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Torreta : MonoBehaviour
{
    public AudioSource audiosource;
    public GameObject proyectilPrefab;
    public Transform puntoDisparo;
    public GameObject jugador;

    public float tiempoEntreDisparos = 2f;
    public float velocidadProyectil = 10f;

    private float tiempoSiguienteDisparo;

    private NavMeshAgent AGENTE;

    public void Awake()
    {
        AGENTE = GetComponent<NavMeshAgent>();

    }
    public void Start()
    {

        jugador = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        ApuntarAlJugador();

        if (Time.time >= tiempoSiguienteDisparo)
        {
            Disparar();
            
            tiempoSiguienteDisparo = Time.time + tiempoEntreDisparos;
            audiosource.Play();
        }





    }

    void ApuntarAlJugador()
    {
        if (jugador != null)
        {
            Vector2 direccion = jugador.transform.position - transform.position;
            float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angulo));
        }


    }

    void Disparar()
    {
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDisparo.position, puntoDisparo.rotation);
        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();
        rb.velocity = puntoDisparo.right * velocidadProyectil;
        
    }
}


