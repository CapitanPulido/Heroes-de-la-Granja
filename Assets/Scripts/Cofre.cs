using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{

    public bool recogido = true;
    public Transform controlspawn;
    public Transform controlspawn2;
    
    public float Abre;
    public Arrow arrow;

    public GameObject medkit;
    public GameObject municion;
   

    private Animator animator;
    public bool Oleada1 = false;
    public bool Oleada2 = false;
    public bool Oleada3 = false;
    public bool Oleada4 = false;
    public bool Oleada5 = false;
    public bool Oleada6 = false;
    public bool Oleada7 = false;
    public bool Oleada8 = false;
    public bool Oleada9 = false;
    public bool Oleada10 = false;

  

    void Start()
    {
        arrow = GameObject.FindGameObjectWithTag("Flecha").GetComponent<Arrow>();

        animator = GetComponent<Animator>();
        arrow.ActiveArrow();

    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (recogido && collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(AbrirCofre());
            arrow.DesactiveArrow();
        }
        
    }

    IEnumerator AbrirCofre()
    {
        recogido=false;
        animator.Play("Abierto");

        yield return new WaitForSeconds(Abre);

        if (Oleada1)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }
        if (Oleada2)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }
        if (Oleada3)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }
        if (Oleada4)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }
        if (Oleada5)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }
        if (Oleada6)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }
        if (Oleada7)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }

        if (Oleada8)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }
        if (Oleada9)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }
        if (Oleada10)
        {
            Instantiate(medkit, controlspawn.position, controlspawn.rotation);

            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
            Instantiate(municion, controlspawn2.position, controlspawn2.rotation);
        }

        yield return new WaitForSeconds(2);

        Destroy(gameObject);
    }

    public void ActivarOleada1()
    {
        Oleada1 = true;
        Oleada2 = false;
        Oleada3 = false;
        Oleada4 = false;
        Oleada5 = false;
        Oleada6 = false;
        Oleada7 = false;
        Oleada8 = false;
        Oleada9 = false;
        Oleada10 = false;
    }
    public void ActivarOleada2()
    {
        Oleada1 = false;
        Oleada2 = true;
        Oleada3 = false;
        Oleada4 = false;
        Oleada5 = false;
        Oleada6 = false;
        Oleada7 = false;
        Oleada8 = false;
        Oleada9 = false;
        Oleada10 = false;
    }
    public void ActivarOleada3()
    {
        Oleada1 = false;
        Oleada2 = false;
        Oleada3 = true;
        Oleada4 = false;
        Oleada5 = false;
        Oleada6 = false;
        Oleada7 = false;
        Oleada8 = false;
        Oleada9 = false;
        Oleada10 = false;
    }
    public void ActivarOleada4()
    {
        Oleada1 = false;
        Oleada2 = false;
        Oleada3 = false;
        Oleada4 = true;
        Oleada5 = false;
        Oleada6 = false;
        Oleada7 = false;
        Oleada8 = false;
        Oleada9 = false;
        Oleada10 = false;
    }
    public void ActivarOleada5()
    {
        Oleada1 = false;
        Oleada2 = false;
        Oleada3 = false;
        Oleada4 = false;
        Oleada5 = true;
        Oleada6 = false;
        Oleada7 = false;
        Oleada8 = false;
        Oleada9 = false;
        Oleada10 = false;
    }
    public void ActivarOleada6()
    {
        Oleada1 = false;
        Oleada2 = false;
        Oleada3 = false;
        Oleada4 = false;
        Oleada5 = false;
        Oleada6 = true;
        Oleada7 = false;
        Oleada8 = false;
        Oleada9 = false;
        Oleada10 = false;
    }
    public void ActivarOleada7()
    {
        Oleada1 = false;
        Oleada2 = false;
        Oleada3 = false;
        Oleada4 = false;
        Oleada5 = false;
        Oleada6 = false;
        Oleada7 = true;
        Oleada8 = false;
        Oleada9 = false;
        Oleada10 = false;
    }
    public void ActivarOleada8()
    {
        Oleada1 = false;
        Oleada2 = false;
        Oleada3 = false;
        Oleada4 = false;
        Oleada5 = false;
        Oleada6 = false;
        Oleada7 = false;
        Oleada8 = true;
        Oleada9 = false;
        Oleada10 = false;
    }
    public void ActivarOleada9()
    {
        Oleada1 = false;
        Oleada2 = false;
        Oleada3 = false;
        Oleada4 = false;
        Oleada5 = false;
        Oleada6 = false;
        Oleada7 = false;
        Oleada8 = false;
        Oleada9 = true;
        Oleada10 = false;
    }
    public void ActivarOleada10()
    {
        Oleada1 = false;
        Oleada2 = false;
        Oleada3 = false;
        Oleada4 = false;
        Oleada5 = false;
        Oleada6 = false;
        Oleada7 = false;
        Oleada8 = false;
        Oleada9 = false;
        Oleada10 = true;
    }
    

}
