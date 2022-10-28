using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogosAlcalde : MonoBehaviour
{
    public GameObject Charla;
    public Text MensajesUI;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject siguiente;
    public GameObject AlcaldeF1;
    public GameObject AlcaldeF2;
    public GameObject AplicarLacura;

    public void Alcalde()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            MensajesUI.text = "Regresaste";
            Charla.SetActive(true);
            Box2.SetActive(true);
            Destroy(Box1);
            Destroy(AlcaldeF1);
        }
    }

    public void AlcaldeF()
    {
        AlcaldeF1.SetActive(true);
    }

    public void Curar()
    {
        AlcaldeF2.SetActive(true);
    }

    public void Aplicar()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(AlcaldeF2);
            Destroy(AplicarLacura);
        }
    }

    public void Alcalde1()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Rapido aplicale la medicina al compañero";
            Destroy(Box2);
            Box3.SetActive(true);
        }
    }

    public void Alcalde2()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Presiona G para abrir el Almanaque";
            Destroy(Box3);
            siguiente.SetActive(true);
        }
    }

    public void Alcalde3()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Destroy(siguiente);
            Charla.SetActive(false);
        }
    }
           
}
