using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Purchasing;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Windows;


public class Arrow : MonoBehaviour
{
    public GameObject drops;

    private NavMeshAgent AGENTE;
    
    private Vector2 input;
    public GameObject Pointer;

    public void Awake()
    {
        AGENTE = GetComponent<NavMeshAgent>();

    }

    public void Start()
    {
        Pointer.SetActive(false);
        //drops = GameObject.FindGameObjectWithTag("cofre");
    }
    void Update()
    {
        ApuntarAlJugador();
    }
    void ApuntarAlJugador()
    {
        if (drops != null)
        {
            Vector2 direccion = drops.transform.position - transform.position;
            float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angulo));
        }
        //else
        //{
        //    this.gameObject.SetActive(false);
        //}

    }
    public void ActiveArrow()
    {
        Pointer.SetActive(true);
    }

    public void DesactiveArrow()
    {
        Pointer.SetActive(false);
    }


}
