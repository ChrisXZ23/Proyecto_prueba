using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recoleccion : MonoBehaviour
{
    public GameObject particula1;
    public GameObject particula2;
    public GameObject particula3;
    public GameObject particula4;
    public GameObject hierbas1;
    public GameObject hierbas2;
    public GameObject hierbas3;
    public GameObject hierbas4;

    [SerializeField] private int NumeroHierbas;
    public GameObject cuadroTrigger1;
    public GameObject cuadroTrigger2;
    public GameObject cuadroTrigger3;
    public GameObject cuadroTrigger4;

    public GameObject MensajeInicio;
    public Text mensajeB;
    public Text ConteoDePlantas;
    public GameObject PlantasNumeros;
    public Text Pensamientos;
    public Text PensamientosBotones;
    public Text Objetivos;
    public GameObject Cuadropensamiento;
    
    public GameObject cuadroObjetivo;
    public GameObject cuboB;

    public GameObject CuboP;
    public Transform pointSpawn;
    public GameObject cuboPs;

    public GameObject entradaCueva;
    //public Transform TransformPlayer;
    public GameObject enemigo;




    public void MensajeBienvenida()
    {
        MensajeInicio.SetActive(true);
        mensajeB.text = "El Bosque";
        cuadroObjetivo.SetActive(true);
        Objetivos.text = "Busca las plantas medicinales";
        PlantasNumeros.SetActive(true);
    }
    public void BmensajeBienvenida()
    {
        Destroy(cuboB);
        Destroy(mensajeB);
    }


    public void recogerHierbas()
    {
        Recoletar1();
        MensajeRecolectar();
    }

    public void recogerHierbas2()
    {
        Recoletar2();
        MensajeRecolectar();
    }

    public void recogerHierbas3()
    {
        Recoletar3();
        MensajeRecolectar();
    }

    public void recogerHierbas4()
    {
        Recoletar4();
        MensajeRecolectar();
    }

    void numeroH()
    {
        NumeroHierbas++;
        if (NumeroHierbas == 1)
        {
            //Debug.Log("Aún queda más planta");
            ConteoDePlantas.text = "1 / 4";
        }
        if (NumeroHierbas == 2)
        {
            //Debug.Log("Aún queda más planta");
            ConteoDePlantas.text = "2 / 4";
        }
        if (NumeroHierbas == 3)
        {
            //Debug.Log("Aún queda más planta");
            ConteoDePlantas.text = "3 / 4";
        }
        if (NumeroHierbas == 4)
        {
            //Debug.Log("La ultima planta se encuentra adentro de la cueva");
            ConteoDePlantas.text = "4 / 4";
            CuboP.SetActive(true);
            PlantasNumeros.SetActive(false);

            CuboP.transform.position = pointSpawn.position;


        }
    }

    public void pensamientoB()
    {
        
        Cuadropensamiento.SetActive(true);
        cuadroObjetivo.SetActive(false);
        Pensamientos.text = "*Cuatro plantas no alcanzaran para los enfermos, deberia de buscar una más*";
        PensamientosBotones.text = "Presiona L para continuar";

        if (Input.GetKeyDown(KeyCode.L))
        {
            Cuadropensamiento.SetActive(false);
            cuadroObjetivo.SetActive(true);


            Destroy(CuboP);
            Objetivos.text = "Investiga la cueva";
            PlantasNumeros.SetActive(true);
            cuboPs.SetActive(true);
            cuboPs.transform.position = pointSpawn.position;


        }
    }

    public void borrarcuboPs()
    {

        Destroy(cuboPs);

    }



    public void cuevaEntrada()
    {
        if(NumeroHierbas == 4)
        {
            Cuadropensamiento.SetActive(true);
            Pensamientos.text = "Presiona F para entrar";
            PensamientosBotones.text = "";
        }
        if (NumeroHierbas <= 3)
        {
            Cuadropensamiento.SetActive(true);
            Pensamientos.text = ("*Deberia buscar primero en el bosque antes de entrar*");
            PensamientosBotones.text = "";
        }


    }

    public void cuevaSalida()
    {
        Cuadropensamiento.SetActive(false);
        
    }



    void Recoletar1()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(hierbas1);
            Destroy(cuadroTrigger1);
            Destroy(particula1);

            numeroH();
            //Debug.Log("Has recogido " + NumeroHierbas);

        }
    }


    void Recoletar2()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(hierbas2);
            Destroy(cuadroTrigger2);
            Destroy(particula2);

            numeroH();
            //Debug.Log("Has recogido "+ NumeroHierbas);


        }

    }

    void Recoletar3()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(hierbas3);
            Destroy(cuadroTrigger3);
            Destroy(particula3);

            numeroH();
            //Debug.Log("Has recogido " + NumeroHierbas);


        }

    }
    void Recoletar4()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(hierbas4);
            Destroy(cuadroTrigger4);
            Destroy(particula4);

            numeroH();
            //Debug.Log("Has recogido " + NumeroHierbas);


        }

    }


    void MensajeRecolectar()
    {
        //Debug.Log("Recolectar con F");
        Objetivos.text = "Recolectar planta con F";
    }






    void Enemigo()
    {
        enemigo.SetActive(true);
    }





}
