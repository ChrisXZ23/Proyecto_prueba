using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public GameObject BotonInicio;
    public GameObject PanelPausa;

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
    }

    public void Regreso()
    {
        SceneManager.LoadScene(0);
    }

    public void AbrirAlmanaque()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(5);
        }
    }
}