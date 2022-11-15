using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Activar_pelea : MonoBehaviour
{
    public GameObject oso;
    public GameObject sonidoCueva;
    public GameObject musicaPelea;
    public GameObject camaraD;
    public GameObject camaraP;
    public GameObject BloqueoEntrada;
    public GameObject bCueva;
    public GameObject Mcueva;
    public GameObject plantaF;
    public GameObject RecoF;
    public GameObject activarDialogosc;
    public GameObject DialogoCueva;
    public Text DialogoPensamiento;
    public Text DialogoPensamiento2;
    public GameObject CuadroObjetivo;
    public Text Objetivos;
    public Transform pointPlayer;



    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void cueva()
    {
        CuadroObjetivo.SetActive(true);
        Mcueva.SetActive(true);
        Objetivos.text = "Busca la planta restante";
    }

    public void mensajeCueva()
    {
        Destroy(bCueva);
        Mcueva.SetActive(false);


    }

    
    public void activarP()
    {
        Objetivos.text = "Presiona F para recolectar";
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(plantaF);
            activarDialogosc.transform.position = pointPlayer.position;
            Destroy(RecoF);
            DialogoCueva.SetActive(true);
            CuadroObjetivo.SetActive(false);
            camaraD.SetActive(true);
            camaraP.SetActive(false);
        }
    }

    public void activarDialogos()
    {
        DialogoPensamiento.text = "*Con esta planta bastara para la medicina para los enfermos*";
        DialogoPensamiento2.text = "Presiona L para continuar";

        if (Input.GetKeyDown(KeyCode.L))
        {
            BloqueoEntrada.SetActive(true);
            oso.SetActive(true);
            DialogoCueva.SetActive(false);
            CuadroObjetivo.SetActive(true);
            Objetivos.text = "Mata al oso";

            sonidoCueva.SetActive(false);
            musicaPelea.SetActive(true);

            Destroy(camaraD);
            camaraP.SetActive(true);
        }



    }

    public void activarDialogos2()
    {
        BloqueoEntrada.SetActive(true);
        oso.SetActive(true);
        DialogoCueva.SetActive(false);
        CuadroObjetivo.SetActive(true);
        Objetivos.text = "Mata al oso";

        sonidoCueva.SetActive(false);
        musicaPelea.SetActive(true);
        Destroy(camaraD);
        camaraP.SetActive(true);
    }

    public void noSalida()
    {
        DialogoCueva.SetActive(true);
        DialogoPensamiento.text = "Debes de buscar la ultima planta";
        DialogoPensamiento2.text = "";
        CuadroObjetivo.SetActive(false);

        SceneManager.LoadScene(5);
    }

    public void noSalida2()
    {
        DialogoCueva.SetActive(false);
        CuadroObjetivo.SetActive(true);
    }
}
