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
    public GameObject salidaC;
    public GameObject bCueva;
    public GameObject Mcueva;
    public GameObject contadorPlantas;
    public Text contadorPlantasT;
    public int contadorPlantasN;
    public GameObject imagenPlanta;
    public GameObject plantaF;
    public GameObject RecoF;
    public GameObject RecoF2;
    public GameObject activarDialogosc;
    public GameObject DialogoCueva;
    public Text DialogoPensamiento;
    public Text DialogoPensamiento2;
    public GameObject CuadroObjetivo;
    public Text Objetivos;
    public Transform pointPlayer;
    public GameObject Salida;


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
        contadorPlantas.SetActive(true);
        imagenPlanta.SetActive(true);
        contadorPlantasT.text = "4 / 5";
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
            RecoF2.SetActive(true);
            salidaC.SetActive(false);

            contadorPlantasN += 1;
            contadorPlantasT.text = "5 / 5";
            contadorPlantas.SetActive(false);
            imagenPlanta.SetActive(false);
        }
    }

    public void activarDialogos()
    {
        DialogoPensamiento.text = "*Con esta planta bastar? para hacer la medicina, deber?a de volver con el alcalde*";
        DialogoPensamiento2.text = "Presiona L para continuar";
        

        if (Input.GetKeyDown(KeyCode.L))
        {
            BloqueoEntrada.SetActive(true);
            oso.SetActive(true);
            DialogoCueva.SetActive(false);
            CuadroObjetivo.SetActive(true);
            Objetivos.text = "Derrota al oso para salir de la cueva  -presiona click izquierdo para atacar";

            sonidoCueva.SetActive(false);
            musicaPelea.SetActive(true);

            Destroy(camaraD);
            camaraP.SetActive(true);
            Destroy(RecoF2);

            contadorPlantas.SetActive(true);
            imagenPlanta.SetActive(true);
        }



    }

    public void activarDialogos2()
    {
        BloqueoEntrada.SetActive(true);
        oso.SetActive(true);
        DialogoCueva.SetActive(false);
        CuadroObjetivo.SetActive(true);
        Objetivos.text = "Derrota al oso";

        sonidoCueva.SetActive(false);
        musicaPelea.SetActive(true);
        Destroy(camaraD);
        camaraP.SetActive(true);
    }

    public void noSalida()
    {
        if (contadorPlantasN == 0)
        {
            DialogoCueva.SetActive(true);
            DialogoPensamiento.text = "Debes de buscar la ultima planta";
            DialogoPensamiento2.text = "";
            CuadroObjetivo.SetActive(false);
        }
        if(contadorPlantasN == 1)
        {
            DialogoCueva.SetActive(true);
            DialogoPensamiento.text = "presiona F para salir";
            DialogoPensamiento2.text = "";
            CuadroObjetivo.SetActive(false);
            Salida.SetActive(true);
        }
        

        
    }

    public void noSalida2()
    {
        DialogoCueva.SetActive(false);
        CuadroObjetivo.SetActive(true);
    }
}
