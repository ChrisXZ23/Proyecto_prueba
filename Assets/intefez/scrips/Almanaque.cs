using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almanaque : mensajes
{
    public GameObject Pagina1;
    public GameObject Fabricar;
    public GameObject Aviso;
    public GameObject NewMensaje;

   public void Pagina()
    {
        Pagina1.SetActive(true);

    }

    public void FabricarMedi()
    {
        Aviso.SetActive(true);
        MensajesUI.text = "Medicina fabricada";
        Invoke("ResetearTexto", 2f);
    }

    public void NoSirve()
    {
        MensajesUI.text = "No disponible";
        Aviso.SetActive(true);
        Pagina1.SetActive(false);
        Invoke("ResetearTexto", 2f);
    }

    public void NoCambio()
    {
        MensajesUI.text = "No disponible";
        Aviso.SetActive(true);
        Invoke("ResetearTexto", 2f);
    }
}
