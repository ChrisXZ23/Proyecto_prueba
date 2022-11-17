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
    public GameObject activarAldeano2;
    public GameObject aldeanoCasaAlcalde;
    public GameObject Alcalde;

    public GameObject activarAlcalde;
    public GameObject activarAlcalde1;
    public GameObject activarAlcalde2;
    public GameObject activarAlcalde3;
    public GameObject CamaraAdeanoAlcalde;
    public GameObject CamaraCasaAlcalde;

    public GameObject dialogoAlcalde;
    public GameObject dialogoAlcalde1;
    public GameObject dialogoAlcalde2;
    public GameObject dialogoAlcalde3;
    public GameObject dialogoAlcalde4;
    public GameObject CamaraAlcalde;

    public GameObject EntradaBosque;
    public GameObject DesactivarAldeano2;
    public GameObject CamaraBosque;
    public GameObject BarreraBosque;
    public GameObject BarreraBosqueAbierta;



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
    public void ActivarAlcaldeA()
    {
        activarAldeano2.SetActive(true);
        Alcalde.SetActive(true);
    }
    public void DesactivarAlcalde()
    {
        aldeanoCasaAlcalde.SetActive(false);
    }

    public void ActivarmisionAlcalde()
    {
        dialogosUI.text = "Beltran, como te fue?";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(activarAlcalde);
            activarAlcalde1.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAdeanoAlcalde.SetActive(true);
            CamaraProta.SetActive(false);
        }
    }
    public void ActivarmisionAlcalde1()
    {
        dialogosUI.text = "Creo que las bebidas seran para otro momento";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(activarAlcalde1);
            activarAlcalde2.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAdeanoAlcalde.SetActive(false);
            CamaraProta.SetActive(false);
            CamaraCasaAlcalde.SetActive(true);
        }
    }
    public void ActivarmisionAlcalde2()
    {
        dialogosUI.text = "ha ocurrido un problema, el alcalde te necesita... Dirigete hacia su casa";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(activarAlcalde2);
            activarAlcalde3.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAdeanoAlcalde.SetActive(true);
            CamaraProta.SetActive(false);
            CamaraCasaAlcalde.SetActive(false);
        }
    }
    public void ActivarmisionAlcalde3()
    {
        dialogosUI.text = "Es algo serio debes de dirigirte lo antes posible, despues nos veremos";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(activarAlcalde3);
            CuadroD.SetActive(false);
            CamaraAdeanoAlcalde.SetActive(false);
            CamaraProta.SetActive(true);
            CamaraCasaAlcalde.SetActive(false);
            DesactivarAldeano2.SetActive(true);
        }
    }
    public void AldeanoAlcaldeDesactivar()
    {
        activarAldeano2.SetActive(false);
    }
    public void DesactivarIrAlcalde()
    {
        DesactivarAldeano2.SetActive(false);

    }

    public void ActivarDialogoAlcalde()
    {
        dialogosUI.text = "Beltran, Es bueno verte por acá viejo amigo, ha ocurrido una emergencia";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAlcalde);
            dialogoAlcalde1.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAlcalde.SetActive(true);
            CamaraProta.SetActive(false);
        }
    }
    public void ActivarDialogoAlcalde1()
    {
        dialogosUI.text = "El pequeño timmy ha caido en una grave enfermedad... tranquilo es curable el problema es que no cuento con los materiales necesarios";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAlcalde1);
            dialogoAlcalde2.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAlcalde.SetActive(false);
            CamaraProta.SetActive(false);
            CamaraBosque.SetActive(true);
        }
    }
    public void ActivarDialogoAlcalde2()
    {
        dialogosUI.text = "Por favor dirigete hacia la zona del bosque, ingresa por la entrada que esta cerca de tu casa y recolecta la planta medicinal que necesitamos para el antidoto";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAlcalde2);
            dialogoAlcalde3.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAlcalde.SetActive(true);
            CamaraProta.SetActive(false);
            CamaraBosque.SetActive(false);
        }
    }
    public void ActivarDialogoAlcalde3()
    {
        dialogosUI.text = "Es una tarea que solo puedo encargarte a ti, ve con mucho cuidado y buena suerte";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAlcalde3);
            dialogoAlcalde4.SetActive(true);
            CuadroD.SetActive(false);
            CamaraAlcalde.SetActive(true);
            CamaraProta.SetActive(false);
            CamaraBosque.SetActive(false);
        }
    }
    public void ActivarDialogoAlcalde4()
    {
        dialogosUI.text = "Por cierto, ultimamente he sentido una presencia muy extraña en el bosque la cual, ha mantenido de mal humor al oso pardo, ten mucho cuidado si lo encuentras... no cometas alguna locura";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogoAlcalde4);
            CuadroD.SetActive(false);
            CamaraAlcalde.SetActive(false);
            CamaraProta.SetActive(true);
            CamaraBosque.SetActive(false);
            BarreraBosque.SetActive(false);
            BarreraBosqueAbierta.SetActive(true);
            EntradaBosque.SetActive(true);
        }
    }
    
}

