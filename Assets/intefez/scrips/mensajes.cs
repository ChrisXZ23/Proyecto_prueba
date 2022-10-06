using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensajes : MonoBehaviour
{
    public GameObject Variablemensaje;
    public Text MensajesUI;

    public virtual void ResetearTexto()
    {
        MensajesUI.text = "";
        Variablemensaje.SetActive(false);
    }

}
