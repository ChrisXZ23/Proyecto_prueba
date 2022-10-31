using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finaldialogos : MonoBehaviour
{
    public GameObject Charla2;
    public Text MensajesUI;
    public GameObject Caja1;
    public GameObject Caja2;
    public GameObject Caja3;
    

    public void Platica1()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Yo me encargare de cuidarlo hasta que se recupere por completo";
            Destroy(Caja1);
            Caja2.SetActive(true);
        }
    }

    public void Platica2()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Tu deberias irte a descansar, tengo una tarea especial para ti";
            Destroy(Caja2);
            Caja3.SetActive(true);
        }
    }

    public void Platica3()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            MensajesUI.text = "Por ello necesito que mañana vayas al centro de la aldea, por hoy ve a descansar";
            Destroy(Caja3);
            
        }
    }
}
