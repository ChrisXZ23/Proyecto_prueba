using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucciones : mensajes
{
    public GameObject NewMensajes;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Presiona la imagen de la medicina para ver la siguiente pagina.";
            PresionaL.text = "";
        }
            
    }

    public void Pagina12()
    {
        MensajesUI.text = "Al tener los materiales presiona fabricar para crear los objetos.";
    }

    public void Pagina13()
    {
        MensajesUI.text = "Ahora presiona esc para salir del menu";
    }
}
