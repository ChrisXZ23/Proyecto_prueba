using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProta : MonoBehaviour
{
    public float velocidad;
    public float fuerza;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        //transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        transform.Translate(0, Input.GetAxis("Jump") * fuerza, 0);

        movimientoS();
    }

    void movimientoS()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        //noMovimiento();

        if (Input.GetKey("left shift"))
        {
            transform.Translate(Input.GetAxis("Horizontal") * velocidad * 0.3f, 0, Input.GetAxis("Vertical") * velocidad * 0.3f);
        }

    }

    public void noMovimiento()
    {
        if (velocidad == 0.2f)
        {
            //Debug.Log("No hay movimiento");
            velocidad = 0;
            transform.Rotate(0, 0, 0);
        }
    }

    public void sMovimiento()
    {
        if (velocidad == 0)
        {
            //Debug.Log("Hay movimiento");
            velocidad = 0.2f;

            transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        }
    }
}
