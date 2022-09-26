using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensajes : MonoBehaviour
{
    public Text MensajesUI;
    void Start()
    {
        MensajesUI.text = "Agarra el saco, con el boton F";
        Invoke("ResetearTexto", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void ResetearTexto()
    {
        MensajesUI.text = "";
    }

}
