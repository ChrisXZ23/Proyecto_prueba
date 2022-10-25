using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charlaaldeano : mensajes
{
    public GameObject conversando;

    public void conversacion()
    {
        conversando.SetActive(true);
        MensajesUI.text = "";
    }
}
