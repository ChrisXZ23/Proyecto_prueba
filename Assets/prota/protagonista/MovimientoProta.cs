using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoProta : MonoBehaviour
{
    public float velocidad;
    public float fuerza;
    [SerializeField] private float contadorStamina = 100;

    

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

    }

    public void velocidadT()
    {
        if (contadorStamina >= 10)
        {
            if (Input.GetKey("left shift"))
            {
                transform.Translate(Input.GetAxis("Horizontal") * velocidad * 2, 0, Input.GetAxis("Vertical") * velocidad * 2);
            }
        }
    }

    public void VelocidadmenosT()
    {
        if (contadorStamina == 0)
        {
            if (Input.GetKey("left shift"))
            {
                contadorStamina--;
                transform.Translate(Input.GetAxis("Horizontal") * velocidad * 0.01f, 0, Input.GetAxis("Vertical") * velocidad * 0.01f);
            }
        }
    }



    public void noMovimiento()
    {
        if (velocidad >= 0.02f)
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
            velocidad = 0.03f;

            transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        }
    }
}
