using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParaSaco : mensajes
{
    public GameObject Saco;

    public void RecogerSaco()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Saco);
            Variablemensaje.SetActive(true);
            MensajesUI.text = "Tienes el saco, sal de la casa";
            Invoke("ResetearTexto", 2f);
        }
    }

    public void Mevoy()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(2);
            Invoke("ResetearTexto", 2f);
            SceneManager.LoadScene(2);
        }
    }

}
