using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoleccion : MonoBehaviour
{
    public GameObject particula1;
    public GameObject particula2;
    public GameObject hierbas1;
    public GameObject hierbas2;
    public GameObject cuadroMensaje;
    public int NumeroHierbas;
    public GameObject cuadroTrigger1;
    public GameObject cuadroTrigger2;
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
        Recoletar1();
        MensajeRecolectar();
    }

    void Recoletar1()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(hierbas1);
            Destroy(cuadroTrigger1);

            NumeroHierbas ++;
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

            NumeroHierbas ++;
            Debug.Log("Has recogido "+ NumeroHierbas);

            Enemigo();
            desactivarLuzciernaga2();
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
