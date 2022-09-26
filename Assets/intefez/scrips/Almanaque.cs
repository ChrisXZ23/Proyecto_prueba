using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almanaque : mensajes
{

    public GameObject Pagina1;
    public GameObject Fabricar;

   public void Pagina()
    {
        Pagina1.SetActive(true);
    }

    public void FabricarMedi()
    {
        MensajesUI.text = "Medicina fabricada";
        Invoke("ResetearTexto", 1f);
    }
}
