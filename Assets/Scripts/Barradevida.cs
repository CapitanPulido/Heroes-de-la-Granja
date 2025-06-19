using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barradevida : MonoBehaviour
{

    private Slider slider;
    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    void Update()
    {
        
    }

    public void CambiarVidaMaxima(float VidaMaxima)
    {
        slider.maxValue = VidaMaxima;
    }

    public void CambiarVidaActual(float CantidadVida)
    {
        slider.value = CantidadVida;
    }

    public void InicializarBarradeVida(float CantidadVida)
    {
        CambiarVidaMaxima(CantidadVida);
        CambiarVidaActual(CantidadVida);
    }
}
