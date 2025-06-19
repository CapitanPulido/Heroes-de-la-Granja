using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    [SerializeField] private GameObject Menupausa;
    [SerializeField] private GameObject Estas_Seguro;
    private GameManager gameManager;
    

    public void Awake()
    {
        Menupausa.gameObject.SetActive(false);
     
    }

    void Start()
    {
        gameManager = GameManager.Instance;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pausa();
        }

    }

    public void Reanudar()
    { 
        Time.timeScale = 1f;
        Menupausa.SetActive(false);
    }

    public void Return()
    {
        
        Menupausa.SetActive(false);
        SceneManager.LoadScene("Menu Inicial");
        Time.timeScale = 1f;

    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("MenuSeleccionPersonaje");
        Time.timeScale = 1f;
    }

    public void Pausa()
    {
        Menupausa.gameObject.SetActive(true);
        
        Time.timeScale = 0f;
    }
}
