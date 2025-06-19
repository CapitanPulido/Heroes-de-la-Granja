using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarradeEstamina : MonoBehaviour
{
    private Slider slider;
    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void CambiarEstaminaMaxima(float EstaminaMaxima)
    {
        slider.maxValue = EstaminaMaxima;
    }

    public void CambiarEstaminaActual(float CantidadEstamina)
    {
        slider.value = CantidadEstamina;
    }

    public void InicializarBarradeEstamina(float CantidadEstamina)
    {
        CambiarEstaminaMaxima(CantidadEstamina);
        CambiarEstaminaActual(CantidadEstamina);
    }


}
