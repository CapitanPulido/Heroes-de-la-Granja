using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Menudeseleccionpersonaje2 : MonoBehaviour
{
    private int index;

    //[SerializeField] private Image imagen;
    //[SerializeField] TextMeshProUGUI nombre;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;



    }


    //public void cambiarpantalla()
    //{
    //    PlayerPrefs.SetInt("JugadorIndex" , index);
    //    //imagen.sprite = gameManager.personajes[index].Imagen;
    //    //nombre.text = gameManager.personajes[index].nombre;
    //}

    public void seleccionPersonaje(int num)
    {
        index = num;
        PlayerPrefs.SetInt("JugadorIndex", index);
    }

  
    //public void anteriorpersonaje()
    //{
    //    if (index == 0)
    //    {
    //        index = gameManager.personajes.Count - 1;


    //    }
    //    else
    //    {
    //        index -= 1;
    //    }

    //    cambiarpantalla();
    //}

    public void iniciarjuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
