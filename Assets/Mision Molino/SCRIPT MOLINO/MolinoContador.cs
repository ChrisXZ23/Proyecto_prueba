using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MolinoContador : MonoBehaviour

{
    public int MAIZ;
    public int MaxItems;
    public GameObject FinMisionMaiz;
    public Text textoItems;
    public Text dialogosUI;
    public Text dialogosintUI;
    public GameObject CuadroD;
    //public GameObject completar;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Maiz")
        {
            MAIZ++;
            textoItems.text = MAIZ.ToString() + " de " + MaxItems.ToString();
            Destroy(other.transform.gameObject);
        }
        if (MAIZ == MaxItems)
        {
            misionCompletada();
            FinMisionMaiz.SetActive(true);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "carreta")
        {
            Debug.Log("Mision completada");
        }

    }
    public void misionCompletada()
    {
        //Debug.Log("El viento soplo muy fuerte y tiro todos las mazorcas al suelo, se encuentran regados en toda la area de los cultivos -presiona F para continuar");
        dialogosUI.text = "Regresa con el granjero";
        dialogosintUI.text = "presiona F para continuar";
        CuadroD.SetActive(true);
        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(dialogosintUI);
            Destroy(dialogosUI);
            //arribaP();
            CuadroD.SetActive(false);
        }
    }

}
