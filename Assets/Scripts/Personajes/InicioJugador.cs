using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioJugador : MonoBehaviour
{
    private void Awake()
    {
        int indexJugador = PlayerPrefs.GetInt("JugadorIndex");

        Instantiate(GameManager.Instance.personajes[indexJugador].PersonajeJugable, transform.position, Quaternion.identity);
    }
    private void Start()
    {
        
    }
    
    
}
