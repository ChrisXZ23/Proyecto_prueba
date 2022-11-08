using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogosFinales : MonoBehaviour
{
    public GameObject AlcaldeBase1;
    public GameObject Charlafinal;
    public Text MensajesUI;
    public GameObject Caja1;
    public GameObject Caja2;
    public GameObject Caja3;

    public void Detalles()
    {
        AlcaldeBase1.SetActive(false);
    }

    public void Final1()
    {
        Charlafinal.SetActive(true);
        Destroy(Caja1);
        Caja2.SetActive(true);
    }

    public void Final2()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Yo lo cuidare hasta que se mejore";
        }
    }
}
