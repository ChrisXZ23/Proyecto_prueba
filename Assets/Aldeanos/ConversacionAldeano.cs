using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversacionAldeano : MonoBehaviour
{
    public Text dialogosUI;
    public Text dialogosintUI;
    public GameObject CuadroD;

    public GameObject ActivarMisAldea;
    public GameObject dialogoAldea1;
    public GameObject dialogoAldea2;
    public GameObject dialogoAldea3;
    public GameObject dialogoAldea4;

    public GameObject CamaraProta;
    public GameObject CamaraMolino;
    public GameObject CamaraGranja;
    public GameObject CamaraAldeanomis;

    public GameObject DesactivarAldeano;
    public GameObject aldeanoMisiones;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void mensajeAldeano1()
    {
        dialogosUI.text = "Hola Bertran, como has estado";
        CuadroD.SetActive(true);
    }
    public void mensajeAldeano2()
    {
        dialogosUI.text = "Hola Bertran, lindo dia";
        CuadroD.SetActive(true);
    }
    public void mensajeAldeano3()
    {
        dialogosUI.text = "Hey Bertran, este dia ha estado un poco extraño";
        CuadroD.SetActive(true);
    }
    public void mensajeAldeano4()
    {
        dialogosUI.text = "Hey Bertran, no presientes que algo ocurrira";
        CuadroD.SetActive(true);
    }
    public void salirMensajeAldeano()
    {
        CuadroD.SetActive(false);
    }

    public void ActivarmisionesAldea()
    {
        dialogosUI.text = "Beltran, te he estado buscando, nos esperan muchas tareas para el dia de hoy";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(ActivarMisAldea);
            dialogoAldea1.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAldeanomis.SetActive(true);
            CamaraProta.SetActive(false);
        }
    }

    public void ActivarmisionesAldea1()
    {
        dialogosUI.text = "Ahora que tengo toda tu atencion lo siguiente que debemos de hacer es...";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAldea1);
            dialogoAldea2.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAldeanomis.SetActive(false);
            CamaraProta.SetActive(false);
            CamaraMolino.SetActive(true);
        }
    }
    public void ActivarmisionesAldea2()
    {
        dialogosUI.text = "debes de ir con la señora, habla con ella y ayudala a recolectar la cosecha de este año";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAldea2);
            dialogoAldea3.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAldeanomis.SetActive(false);
            CamaraProta.SetActive(false);
            CamaraMolino.SetActive(false);
            CamaraGranja.SetActive(true);
        }
    }
    public void ActivarmisionesAldea3()
    {
        dialogosUI.text = "despues dirigete a la granja, debemos de ayudar al señor sus gallinas, se volvieron a escapar";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAldea3);
            dialogoAldea4.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAldeanomis.SetActive(true);
            CamaraProta.SetActive(false);
            CamaraMolino.SetActive(false);
            CamaraGranja.SetActive(false);
        }
    }
    public void ActivarmisionesAldea4()
    {
        dialogosUI.text = "por el momento realiza esas tareas y cuando termines buscame frente a la fuente para ir por algo de beber";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAldea4);
            CuadroD.SetActive(false);
            CamaraAldeanomis.SetActive(false);
            CamaraProta.SetActive(true);
            CamaraMolino.SetActive(false);
            CamaraGranja.SetActive(false);
            DesactivarAldeano.SetActive(true);
        }
    }
    public void DesactivarAldeanoMiones()
    {
        aldeanoMisiones.SetActive(false);
    }
    public void DesactivarDesactiv()
    {
        DesactivarAldeano.SetActive(false);
    }
}

