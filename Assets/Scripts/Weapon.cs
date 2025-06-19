using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Weapon : MonoBehaviour
{
    //private Camera Cam;
    public Camera Camera;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            StartCoroutine(AnimGun());
        }

        //Debug.Log(Input.mousePosition);

        Vector2 mouseWorldPoint = Camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mouseWorldPoint - (Vector2)transform.position;
        transform.up = direction;
        //Debug.Log(mouseWorldPoint);
    }

    IEnumerator AnimGun()
    {
        animator.Play("ArmaShooting");
        yield return new WaitForSeconds(1);
        animator.Play("Gun Idle");
    }
}
