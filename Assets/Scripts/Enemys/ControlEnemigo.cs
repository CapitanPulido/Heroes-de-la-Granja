using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ControlEnemigo : MonoBehaviour
{
   
    public GameObject prefabenemigolobo;
    public GameObject prefabenemigooso;
    public GameObject prefabenemigomapache;
    public GameObject prefabenemigoardilla;
    public int numerolobos;
    public int numeroosos;
    public int numeromapaches;
    public int numeroardillas;
    public Transform spawnenemy;
    public int numerooleada = 1;
    public int numeroenemigos;
    public float tiempoentreoleada;
    public Transform controlspawn3;
    public GameObject tempo;

    public GameObject cofre;
    
    

    public float TiempoMaximo;
    public float tiempoactual;
    public TextMeshProUGUI oleada;

    public Slider tempoizador;

    public bool iniciaroleada = true;
    public bool tiempoActivado;
    public Cofre drops;

    
    
    void Start()
    {
        StartCoroutine(Oleada());
        ActivarTemporizador();

    }
    void Update()
    {

        numerolobos = FindObjectsOfType<Lobo> ().Length;
        numeroosos = FindObjectsOfType<Oso>().Length;
        numeromapaches = FindObjectsOfType<Mapache>().Length;
        numeroardillas = FindObjectsOfType<Ardilla>().Length;

        numeroenemigos = numerolobos + numeroosos + numeromapaches + numeroardillas;
        

        if (iniciaroleada && numeroenemigos == 0)
        {
            
            numerooleada++;
            

            StartCoroutine(Oleada());

            oleada.text = numerooleada.ToString();

            Instantiate(cofre, controlspawn3.position, controlspawn3.rotation);
            ActivarTemporizador();
            tempo.gameObject.SetActive(true);
        }
    
       if (tiempoActivado)
        {
            CambiarContador();
        }
        if (numerooleada >= 1)
        {
            drops.ActivarOleada1();

        }
        if (numerooleada >= 2)
        {
            drops.ActivarOleada2();

        }
        if (numerooleada >= 3)
        {

            drops.ActivarOleada3();
        }
        if (numerooleada >= 4)
        {
            drops.ActivarOleada4();

        }
        if (numerooleada >= 5)
        {

            drops.ActivarOleada5();
        }
        if (numerooleada >= 6)
        {
            drops.ActivarOleada6();

        }
        if (numerooleada >= 7)
        {
            drops.ActivarOleada7();

        }
        if (numerooleada >= 8)
        {

            drops.ActivarOleada8();
        }
        if (numerooleada >= 9)
        {

            drops.ActivarOleada9();
        }
        if (numerooleada >= 10)
        {
            drops.ActivarOleada10();

        }
        if (numerooleada >= 11)
        {
            SceneManager.LoadScene("MenuVictoria");

        }

    }

    public void CrearEnemylobo(int enemigosagenerar)
    {
        for (int i = 0; i < enemigosagenerar; i++)
        {
            
            Instantiate(prefabenemigolobo, spawnenemy.position, prefabenemigolobo.transform.rotation);
            numeroenemigos++;
        }
    }

    public void CrearEnemyoso(int enemigosagenerar)
    {
        for (int i = 0; i < enemigosagenerar; i++)
        {

            Instantiate(prefabenemigooso, spawnenemy.position, prefabenemigooso.transform.rotation);
            numeroenemigos++;
        }
    }

    public void CrearEnemymapache(int enemigosagenerar)
    {
        for (int i = 0; i < enemigosagenerar; i++)
        {

            Instantiate(prefabenemigomapache, spawnenemy.position, prefabenemigomapache.transform.rotation);
            numeroenemigos++;
        }
    }

    public void CrearEnemyardilla(int enemigosagenerar)
    {
        for (int i = 0; i < enemigosagenerar; i++)
        {

            Instantiate(prefabenemigoardilla, spawnenemy.position, prefabenemigoardilla.transform.rotation);
            numeroenemigos++;
        }
    }

   IEnumerator Oleada()
    {
        iniciaroleada = false;
        
        yield return new WaitForSeconds(tiempoentreoleada);

        CrearEnemylobo(numerooleada);
        CrearEnemyoso(numerooleada);
        CrearEnemymapache(numerooleada);
        CrearEnemyardilla(numerooleada);

        iniciaroleada = true;
        tempo.gameObject.SetActive(false);
    }

    public void CambiarContador()
    {
        tiempoactual -= Time.deltaTime;
        if (tiempoactual >= 0)
        {
            tempoizador.value = tiempoactual;
        }
        if (tiempoactual <= 0)
        {
            CambiarTemporizador(false);
        }
    }

    public void CambiarTemporizador(bool estado )
    {
        tiempoActivado = estado;
    }

    public void ActivarTemporizador()
    {
        tiempoactual = TiempoMaximo;
        tempoizador.maxValue = TiempoMaximo;
        CambiarTemporizador(true);
    }
}
