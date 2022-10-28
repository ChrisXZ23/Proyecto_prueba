using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParaSaco : mensajes
{
    public GameObject Saco;
    public GameObject FF;
    private Animator TranscionAnim;
    public GameObject ParaF;
    public GameObject FF2;
    public GameObject ParaF2;

    void Start()
    {
        TranscionAnim = GetComponent<Animator>();
    }

    public void FBoton()
    {
        FF.SetActive(true);
        Destroy(ParaF);
    }

    public void FBoton2()
    {
        FF2.SetActive(true);
        Destroy(ParaF2);
    }

    public void RecogerSaco()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Saco);
            Variablemensaje.SetActive(true);
            MensajesUI.text = "Tienes el saco, sal de la casa";
            Invoke("ResetearTexto", 2f);
            FF.SetActive(false);
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
