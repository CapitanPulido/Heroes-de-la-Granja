using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Cerdo cerdo;
    private Gallo gallo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cerdo.TomarDa�o();
            gallo.TomarDa�o();
            cerdo.TomarDa�o();
            cerdo.TomarDa�o();
            cerdo.TomarDa�o();
            cerdo.TomarDa�o();
            cerdo.TomarDa�o();
            cerdo.TomarDa�o();
            cerdo.TomarDa�o();
            cerdo.TomarDa�o();
        }
    }
}
