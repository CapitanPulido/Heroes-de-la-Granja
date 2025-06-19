using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class Camara : MonoBehaviour
{

    public float smooth;
    public Vector2 minpos;
    public Vector2 maxpos;
    
    private GameObject player;

    //23 x
    // y 14.5  -15
   


    // Start is called before the first frame update

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
    //    if(transform.position.x < 23  && transform.position.x > -23 )
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x , player.transform.position.y, -10),30f*Time.deltaTime);

    //    }

    //    if(transform.position.y < 14.5  && transform.position.y > -15 )
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x , player.transform.position.y, -10),30f*Time.deltaTime);

    //    }
        if (player != null)
        {
            Vector3 posiciociondeseada = player.transform.position;
            posiciociondeseada.x = Mathf.Clamp(posiciociondeseada.x, minpos.x, maxpos.x);
            posiciociondeseada.y = Mathf.Clamp(posiciociondeseada.y, minpos.y, maxpos.y);
            posiciociondeseada.z = transform.position.z;

            Vector3 smoothpos = Vector3.Lerp(transform.position, posiciociondeseada, smooth);
            transform.position = smoothpos;
        }



    }
}
