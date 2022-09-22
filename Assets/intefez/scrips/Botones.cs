using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public GameObject BotonInicio;
    public GameObject PanelPausa;
    public GameObject SalirAldea;

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

        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(1);
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

    public void OtraScene()
    {
      SceneManager.LoadScene(2);
    }
}