using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParaSaco : mensajes
{
    public GameObject Saco;
    private Animator TranscionAnim;

    void Start()
    {
        TranscionAnim = GetComponent<Animator>();
    }

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

    public void Mevoy(string scene)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Transiciona(scene));
        }
    }

    IEnumerator Transiciona(string scene)
    {
        TranscionAnim.SetTrigger("salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
