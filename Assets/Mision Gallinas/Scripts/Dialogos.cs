using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogos : MonoBehaviour
{
    public GameObject DialogoI;
    public GameObject DialogoP;
    public GameObject DialogoF;
    public GameObject DialogoM;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mensaje1()
    {
        Debug.Log("Hola, Beltran necesito tu ayuda  -presiona F para continuar");
        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(DialogoI);
            DialogoP.SetActive(true);
            arribaP();
        }
    }

    public void mensaje2()
    {
        Debug.Log("Mis gallinas se escaparon del gallinero y no puedo agarrarlas ya que son muy rapidas  -presiona F para continuar");
        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(DialogoP);
            DialogoF.SetActive(true);
            arribaF();
        }
    }

    public void mensaje3()
    {
        Debug.Log("¿Me ayudarias a atraparlas y ponerlas en el gallinero?  -presiona F para continuar");
        if (Input.GetKeyUp(KeyCode.F))
        {
            Destroy(DialogoF);
            DialogoM.SetActive(true);
            arribaM();
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
