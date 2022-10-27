using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MolinoDialogos : MonoBehaviour
{
    public GameObject Dialogo1;
    public GameObject Dialogo2;
    public GameObject Dialogo3;
    //public GameObject Dialogo4;
    public Text dialogosUI;
    public Text dialogosintUI;
    public GameObject CuadroD;
    public GameObject Camaraplayer;
    public GameObject CamaraMolino;


    void Start()
    {

    }


    void Update()
    {

    }
    public void mensajemolino1()
    {
        //Debug.Log("El viento soplo muy fuerte y tiro todos las mazorcas al suelo, se encuentran regados en toda la area de los cultivos -presiona F para continuar");
        dialogosUI.text = "El viento soplo muy fuerte y tiro todos las mazorcas al suelo, se encuentran regados en toda la area de los cultivos";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);
        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(Dialogo1);
            Dialogo2.SetActive(true);
            //arribaP();
            CuadroD.SetActive(false);


        }
    }

    public void mensajemolino2()
    {
        //Debug.Log("¿podrias ayudarme a colocarlor dentro de la carreta y traerlos acá?  -presiona F para continuar");
        dialogosUI.text = "¿podrias ayudarme a colocarlor dentro de la carreta y traerlos acá?";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);


        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(Dialogo2);
            Dialogo3.SetActive(true);
            //arribaF();
            CuadroD.SetActive(false);

        }
    }

    public void mensajemolino3()
    {
        //Debug.Log("acercate al objeto y presiona F para sostener el objeto, presiona E para soltarlo  -presiona F para continuar");
        dialogosUI.text = "acercate al objeto y presiona F para sostener el objeto, presiona E para soltarlo";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);


        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(Dialogo3);
            //Dialogo4.SetActive(true);
            //arribaM();
            CuadroD.SetActive(false);
            CamaraMolino.SetActive(false);
            Camaraplayer.SetActive(true);
        }
    }
}