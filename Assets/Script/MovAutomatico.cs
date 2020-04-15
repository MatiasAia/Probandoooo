using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAutomatico : MonoBehaviour
{
    bool izquierda = false;
    public int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        //ponele este script al cubo
    }

    // Update is called once per frame
    void Update()
    {
        if (izquierda == false)
        {

            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
        if(transform.position.x > 11.82f) {

            izquierda = true;
        }
        if (izquierda == true) { 

            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        if (transform.position.x < 11.82f) { 

            izquierda = false;
        }
    }
}
