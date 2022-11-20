using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MolinoActivar : MonoBehaviour
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
    public GameObject Maices;
    public GameObject Camaraplayer;
    public GameObject CamaraMolino;

    public Text mensajeMision;
    public GameObject CuadroTexto;
    public GameObject somidoMaiz;

    public GameObject carreta;
    public GameObject imagencompletaMision;
    public GameObject salirmensajeMo;

    private bool activo;

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
            Maices.SetActive(true);
            CamaraMolino.SetActive(true);
            Camaraplayer.SetActive(false);


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
            imagencompletaMision.SetActive(true);
            salirmensajeMo.SetActive(true);
        }
    }

    public void completarMolinoMisionX()
    {
        salirmensajeMo.SetActive(false);
        imagencompletaMision.SetActive(false);
    }
    public void salirMensaje()
    {
        CuadroD.SetActive(false);
    }

    public void agarrarObjestos()
    {
        CuadroTexto.SetActive(true);
        mensajeMision.text = "presiona F para sostener el objeto, presiona E para soltarlo";
        
    }
    public void agarrarObjestoMAIZ()
    {
        CuadroTexto.SetActive(true);
        mensajeMision.text = "presiona F para sostener el objeto, Llevalo a la carreta y sobre el marcador presiona E para soltarlo";
        //somidoMaiz.SetActive(true);

    }
    public void SoltarObjestos()
    {
        CuadroTexto.SetActive(false);
        mensajeMision.text = " ";
        //somidoMaiz.SetActive(false);
    }
    public void sonidoMaiz()
    {
        somidoMaiz.SetActive(true);
    }

    public void girrarCarreta()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            var anim = carreta.GetComponent<Animator>();
            anim.SetBool("carretagirar", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            var anim = carreta.GetComponent<Animator>();
            anim.SetBool("carretagirar", false);
        }
    }
}
