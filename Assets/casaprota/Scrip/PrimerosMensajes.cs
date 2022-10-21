using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerosMensajes : mensajes
{
    public GameObject Principal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Peticion()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Variablemensaje.SetActive(true);
            MensajesUI.text = "Agarra el saco con el boton F";
            Invoke("ResetearTexto", 1f);
            Principal.SetActive(false);
        }
    }
}
