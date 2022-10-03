using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niebla : MonoBehaviour
{
    public GameObject veneno;
    public GameObject nieblaO;
    public GameObject hierbas1;
    public GameObject cuadroTrigger1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void recogerHierba()
    {
        MensajeRecolectar();
        Recoletar3();
        
    }
    void Recoletar3()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            veneno.SetActive(true);
            nieblaO.SetActive(true);
            Destroy(hierbas1);
            Destroy(cuadroTrigger1);


            Debug.Log("CORRE!!!");
        }
    }

 
    void MensajeRecolectar()
    {
        Debug.Log("Recolectar con F");
    }
}
