using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wIN : MonoBehaviour
{

    public MenudeSeleccion Personajes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Win()
    {
        Personajes.ActivePulido();
    }
}
