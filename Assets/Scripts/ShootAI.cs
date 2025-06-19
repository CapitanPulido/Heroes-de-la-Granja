using System.Collections;
using UnityEngine;

public class ShootAI : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float tiempoentredisparo;


    public void Start()
    {
        StartCoroutine(Shoot());
    }


    IEnumerator Shoot()
    {
        while (true) 
        { 
        yield return new WaitForSeconds(tiempoentredisparo);

        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }

}
