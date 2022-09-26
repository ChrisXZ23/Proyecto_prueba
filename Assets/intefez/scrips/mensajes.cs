using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensajes : MonoBehaviour
{
    public Text MensajesUI;
    void Start()
    {
        MensajesUI.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void ResetearTexto()
    {
        MensajesUI.text = "";
    }

    public virtual void Inicio()
    {
        MensajesUI.text = "Agarra el saco";
    }

}
