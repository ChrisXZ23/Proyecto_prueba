using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerosMensajes : mensajes
{
    public GameObject Principal;

    public void Primero1()
    {
        Principal.SetActive(true);
        PresionaL.text = "BELTRAAAAAM, Sal necesito hablar contigo";
        
    }

    public void Peticion()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Destroy(Principal);
            Variablemensaje.SetActive(true);
            MensajesUI.text = "Sal de la casa, usa el boton F para interactuar";
            Invoke("ResetearTexto", 3f);
            Principal.SetActive(false);
        }
    }
}
