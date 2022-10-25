using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ACTIVARMolino : MonoBehaviour
{
    public GameObject ActivarDialogos;
    public GameObject dialogo1;
    //public GameObject carreta;
    //public GameObject maiz;
    public GameObject CONMAIZ;
    public GameObject textMaiz;
    public Text dialogosUI;
    public Text dialogosintUI;
    public GameObject CuadroD;
    public GameObject finMision;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MensajeDeActivasion()
    {
        //Debug.Log("Hey, Beltran ayudame por favor -presiona F para continuar");
        dialogosUI.text = "Hey, Beltran ayudame por favor";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(ActivarDialogos);
            dialogo1.SetActive(true);
            CuadroD.SetActive(false);
            //maiz.SetActive(true);
            //carreta.SetActive(true);
            textMaiz.SetActive(true);
            CONMAIZ.SetActive(true);


        }
    }

    public void TerminarMisionMolino()
    {
        //Debug.Log("Muchas gracias Beltran. -presiona F para terminar");
        dialogosUI.text = "Muchas gracias Beltran.";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);

        if (Input.GetKeyUp(KeyCode.F))
        {

            CuadroD.SetActive(false);
            //CuadroD.SetActive(false);
            //maiz.SetActive(false);
            //carreta.SetActive(false);
            textMaiz.SetActive(false);
            CONMAIZ.SetActive(false);
            Destroy(textMaiz);
            Destroy(CONMAIZ);
            Destroy(ActivarDialogos);
            Destroy(finMision);
        }
    }
}
