using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensajes : MonoBehaviour
{
    public GameObject Variablemensaje;
    public Text MensajesUI;

    public virtual void AgarrarSaco()
    {
        MensajesUI.text = "Agarra el saco, con el boton F";
        Invoke("ResetearTexto", 4f);
        Variablemensaje.SetActive(false);
    }

    public virtual void ResetearTexto()
    {
        MensajesUI.text = "";
        Variablemensaje.SetActive(false);
    }

}
