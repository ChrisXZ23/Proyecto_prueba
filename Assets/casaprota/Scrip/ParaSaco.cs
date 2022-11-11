using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParaSaco : mensajes
{
    private Animator TranscionAnim;
    public GameObject ParaF;
    public GameObject FF2;
    public GameObject ParaF2;

    void Start()
    {
        TranscionAnim = GetComponent<Animator>();
    }

    public void FBoton2()
    {
        FF2.SetActive(true);
        Destroy(ParaF2);
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
