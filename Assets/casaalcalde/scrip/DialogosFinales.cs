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
    public GameObject Caja4;

    public void Final1()
    {
        MensajesUI.text = "okey, con eso será suficiente";
        Charlafinal.SetActive(true);
        AlcaldeBase1.SetActive(false);
    }

    public void FinalSeguido()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Yo lo cuidaré hasta que se mejore";
            Destroy(Caja1);
            Caja2.SetActive(true);
        }
    }

    public void Final2()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Haz trabajado mucho, deberías ir a descansar";
            Destroy(Caja2);
            Caja3.SetActive(true);
        }
    }

    public void Final3()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "¡Ah! casi se me olvida, ve al centro de la aldea mañana";
            Destroy(Caja3);
            Caja4.SetActive(true);
        }
    }

    public void Final4()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Tengo una tarea muy importante para ti";
        }
    }
}
