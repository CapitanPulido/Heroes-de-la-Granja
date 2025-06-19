using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenudeSeleccion : MonoBehaviour
{
    private Animator animator;
    public GameObject Pulido;
    public bool pulido = false;

    public bool escogiopersonaje = false;

    public void Start()
    {
        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);
        Personaje11UI.SetActive(false);
        
    }
    public void Update()
    {
        if (pulido) 
        {
            Pulido.SetActive(true);
        }
    }
    public void Iniciar()
    {
        if(escogiopersonaje)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void Regresar()
    {
        if (escogiopersonaje)
        {
            SceneManager.LoadScene(0);
        }
    }



    

    public GameObject Personaje1UI;
    public GameObject Personaje2UI;
    public GameObject Personaje3UI;
    public GameObject Personaje4UI;
    public GameObject Personaje5UI;
    public GameObject Personaje6UI;
    public GameObject Personaje7UI;
    public GameObject Personaje8UI;
    public GameObject Personaje9UI;
    public GameObject Personaje10UI;
    public GameObject Personaje11UI;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;

    public void Return()
    {
     
      SceneManager.LoadScene(0);
        
    }

    public void Ganso()
    {
       

        Personaje1UI.SetActive(true);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite1;
        //animator.Play("Idle ganso");
    }

    public void Cerdo()
    {
       

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(true);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite2;
        //animator.Play("Idle cerdo");

    }
    public void Pato()
    {
       

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(true);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite3;
        //animator.Play("Idle cerdo");
    }
    public void Perro()
    {
       

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(true);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite4;
        //animator.Play("Idle Perro");
    }

    public void Vaca()
    {
        

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(true);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite5;
        //animator.Play("Idle Vaca");
    }
    public void Gallo()
    {
       

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(true);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite6;
        //animator.Play("Idle Gallo");
    }
    public void Gato()
    {
        

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(true);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite7;
        //animator.Play("Idle Gato");
    }
    public void Conejo()
    {
        

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(true);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite8;
        //animator.Play("Idle Conejo");
    }
    public void Oveja()
    {
       

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(true);
        Personaje10UI.SetActive(false);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite9;
        //animator.Play("Idle Oveja");
    }
    public void Chivo()
    {
        

        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(true);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite10;
        //animator.Play("Idle Chivo");
    }

    public void Puligod()
    {


        Personaje1UI.SetActive(false);
        Personaje2UI.SetActive(false);
        Personaje3UI.SetActive(false);
        Personaje4UI.SetActive(false);
        Personaje5UI.SetActive(false);
        Personaje6UI.SetActive(false);
        Personaje7UI.SetActive(false);
        Personaje8UI.SetActive(false);
        Personaje9UI.SetActive(false);
        Personaje10UI.SetActive(false);
        Personaje11UI.SetActive(true);

        escogiopersonaje = true;

        //Personaje.GetComponent<SpriteRenderer>().sprite = sprite10;
        //animator.Play("Idle Chivo");
    }

    public void ActivePulido()
    {
        pulido = true;
    }
}
