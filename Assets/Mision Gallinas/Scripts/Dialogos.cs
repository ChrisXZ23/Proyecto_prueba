using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogos : MonoBehaviour
{
    public GameObject audioD;
    public GameObject camaraPlayer;
    public GameObject camaraFija;
    public GameObject particulaD;
    public GameObject DialogoI;
    public GameObject DialogoP;
    public GameObject DialogoF;
    public GameObject DialogoM;
    public Text dialogosUI;
    public Text dialogosintUI;
    public GameObject CuadroD;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mensaje1()
    {
        //Debug.Log("Hola, Beltran necesito tu ayuda  -presiona F para continuar");
        dialogosUI.text = "Hola, Beltran necesito tu ayuda";
        dialogosintUI.text = "presiona L para continuar";
        CuadroD.SetActive(true);
        if (Input.GetKeyUp(KeyCode.L))
        {
            Destroy(DialogoI);
            DialogoP.SetActive(true);
            arribaP();
            CuadroD.SetActive(false);

            camaraPlayer.SetActive(false);
            camaraFija.SetActive(true);
            audioD.SetActive(true);
            particulaD.SetActive(false);

        }
    }

    public void mensajeFuera()
    {
        CuadroD.SetActive(false);
    }

    public void mensaje2()
    {
        //Debug.Log("Mis gallinas se escaparon del gallinero y no puedo agarrarlas ya que son muy rapidas  -presiona F para continuar");
        dialogosUI.text = "Mis gallinas se escaparon del gallinero y no puedo agarrarlas ya que son muy rapidas";
        dialogosintUI.text = "presiona L para continuar";
        CuadroD.SetActive(true);


        if (Input.GetKeyUp(KeyCode.L))
        {
            Destroy(DialogoP);
            DialogoF.SetActive(true);
            arribaF();
            CuadroD.SetActive(false);

        }
    }

    public void mensaje3()
    {
        //Debug.Log("¿Me ayudarias a atraparlas y ponerlas en el gallinero?  -presiona F para continuar");
        dialogosUI.text = "¿Me ayudarias a atraparlas y ponerlas en el gallinero?";
        dialogosintUI.text = "presiona L para continuar";
        CuadroD.SetActive(true);


        if (Input.GetKeyUp(KeyCode.L))
        {
            Destroy(DialogoF);
            DialogoM.SetActive(true);
            arribaM();
            CuadroD.SetActive(false);


        }
    }

    void arribaP()
    {
        var animP = DialogoP.GetComponent<Animator>();
        animP.SetBool("dialogoP", true);
    }

    void arribaF()
    {
        var animF = DialogoF.GetComponent<Animator>();
        animF.SetBool("dialogoF", true);
    }

    void arribaM()
    {
        var animM = DialogoM.GetComponent<Animator>();
        animM.SetBool("dialogoM", true);
    }
}
