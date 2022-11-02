using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public GameObject cuadroMensaje;
    [SerializeField] private int NumeroHierbas;
    public GameObject cuadroTrigger1;
    public GameObject cuadroTrigger2;
    public GameObject cuadroTrigger3;
    public GameObject cuadroTrigger4;
    //public Transform TransformPlayer;
    public GameObject enemigo;







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
        if(NumeroHierbas == 1)
        {
            Debug.Log("Aún queda más planta");
        }
        if (NumeroHierbas == 2)
        {
            Debug.Log("Aún queda más planta");
        }
        if (NumeroHierbas == 3)
        {
            Debug.Log("Aún queda más planta");
        }
        if(NumeroHierbas == 4)
        {
            Debug.Log("La ultima planta se encuentra adentro de la cueva");
        }
    }

    void Recoletar1()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(hierbas1);
            Destroy(cuadroTrigger1);

            numeroH();
            Debug.Log("Has recogido " + NumeroHierbas);
            desactivarLuzciernaga();
        }
    }


    void Recoletar2()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(hierbas2);
            Destroy(cuadroTrigger2);

            numeroH();
            Debug.Log("Has recogido "+ NumeroHierbas);

            desactivarLuzciernaga2();
        }

    }

    void Recoletar3()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(hierbas3);
            Destroy(cuadroTrigger3);

            numeroH();
            Debug.Log("Has recogido " + NumeroHierbas);

            //desactivarLuzciernaga2();
        }

    }
    void Recoletar4()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(hierbas4);
            Destroy(cuadroTrigger4);

            numeroH();
            Debug.Log("Has recogido " + NumeroHierbas);

            //desactivarLuzciernaga2();
        }

    }


    void MensajeRecolectar()
    {
        Debug.Log("Recolectar con F");
    }

    public void mensajes()
    {
        Debug.Log("Debes de recolectar 5 hierbas medicinales");
        destruirMensaje();
    }

    void destruirMensaje()
    {
        Destroy(cuadroMensaje);
    }



    void Enemigo()
    {
        enemigo.SetActive(true);
    }

    void activarLuzciernaga()
    {
        particula1.SetActive(true);
    }

    void desactivarLuzciernaga()
    {
        particula1.SetActive(false);
    }

    void activarLuzciernaga2()
    {
        particula2.SetActive(true);
    }

    void desactivarLuzciernaga2()
    {
        particula2.SetActive(false);
    }



}
