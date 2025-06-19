using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform controlshoot;
    [SerializeField] private GameObject bala;
    [SerializeField] private float velocidadentrebala;
    [SerializeField] private TextMeshProUGUI municion;
    [SerializeField] private TextMeshProUGUI municioncompleta;
    public int drop;
    public int drop2;


    public int municiongastada;
    public float cargador = 18;
    public float velocidadderecarga;
    public int municiontotal;
    public int municionderecarga;
    public float municioncargador = 18;
    public float timeanim;

    public bool gatillo = true;
    public bool recharge = false;
    public bool munirest = true;
    public bool cargadorlleno = true;
    private Animator animator;
    public AudioSource AudioSource;
    public Camera Camera;


    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        Camera = Camera.main;
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R)) 
        //{
        //    MunicionMas();
        //}

        if (gatillo && cargadorlleno && Input.GetButton("Fire1"))
        {
            StartCoroutine(Tiro());
            


        }

        municioncompleta.text = municiontotal.ToString();
        municion.text = municioncargador.ToString();

        if (munirest && municioncargador <= 0)
        {
            cargadorlleno = false;
            recharge = true;
            gatillo = false;
            StartCoroutine(recargar());
        }

        if (municioncargador <= 0)
        {
            cargadorlleno = false;
        }

        if (municioncargador > 0)
        {
            cargadorlleno = true;
        }

        if (municiontotal <= 0)
        {
            munirest = false;
            recharge = false;

            
        }

        if(municiontotal >= 18)
        {
            munirest = true;
        }

        

        //Debug.Log(Input.mousePosition);

        Vector2 mouseWorldPoint = Camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mouseWorldPoint - (Vector2)transform.position;
        transform.up = direction;
        //Debug.Log(mouseWorldPoint);
    }

    public void Shoot()
    {
        Instantiate(bala, controlshoot.position, controlshoot.rotation);

        
    }

    IEnumerator Tiro()
    {
        gatillo = false;

        StartCoroutine(AnimGun());

        Shoot();
        municioncargador -= 1;
        AudioSource.Play();
        yield return new WaitForSeconds(velocidadentrebala);
        Shoot();
        municioncargador -= 1;
        AudioSource.Play();
        yield return new WaitForSeconds(velocidadentrebala);
        Shoot();
        municioncargador -= 1;
        AudioSource.Play();
        yield return new WaitForSeconds(velocidadentrebala);
        Shoot();
        municioncargador -= 1;
        AudioSource.Play();
        yield return new WaitForSeconds(velocidadentrebala);
        Shoot();
        municioncargador -= 1;
        AudioSource.Play();
        yield return new WaitForSeconds(velocidadentrebala);
        Shoot();
        municioncargador -= 1;
        AudioSource.Play();
        yield return new WaitForSeconds(2);
        gatillo = true;


    }

    IEnumerator recargar()
    {
        gatillo = false;
        recargando();
        municiontotal -= 18;

        if(municiontotal <= 0)
        {
            municiontotal = 0;
        }
        if(municioncargador >= 18)
        {
            recharge = false;
        }
        yield return new WaitForSeconds(velocidadderecarga);
        gatillo = true;

    }

    public void recargando()
    {
       if(recharge)
        {
            municioncargador += 18;
        }

    }
    IEnumerator AnimGun()
    {
        animator.Play("ArmaShooting");
        yield return new WaitForSeconds(timeanim);
        animator.Play("Gun Idle");
    }

    
    public void MunicionMas()
    {
        Debug.Log("Balas recogidas");
        municiontotal += 18;
    }
}
