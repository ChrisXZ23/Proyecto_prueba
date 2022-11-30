using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public GameObject BotonInicio;
    public GameObject PanelPausa;
    public GameObject Opciones;
    private Animator TranscionAnim;

    void Start()
    {
        TranscionAnim = GetComponent<Animator>();
    }

    public void BotonPlay()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PanelPausa.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void DesactivarPausa()
    {
        PanelPausa.SetActive(false);
        Time.timeScale = 1;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Regreso()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OpcionesdelJuego(string scene)
    {
        StartCoroutine(Transiciona(scene));
    }

    public void RegresarPausa()
    {
        Opciones.SetActive(false);
        Time.timeScale = 0;
    }

    public void Exit()
    {
        Application.Quit();
    }

    IEnumerator Transiciona(string scene)
    {
        TranscionAnim.SetTrigger("salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(6);
    }

    public void regresoFinal()
    {
        SceneManager.LoadScene(0);
    }

}