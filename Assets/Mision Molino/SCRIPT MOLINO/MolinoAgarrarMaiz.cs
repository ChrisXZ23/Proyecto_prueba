using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolinoAgarrarMaiz : MonoBehaviour
{
    public GameObject Corn;
    public Transform Interaction;
    public GameObject Contador;

    private bool activo;

    void Update()
    {
        if (activo == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Corn.transform.SetParent(Interaction);
                Corn.transform.position = Interaction.position;
                Corn.GetComponent<Rigidbody>().isKinematic = true;
                Contador.SetActive(true);


            }

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Corn.transform.SetParent(null);
            Corn.GetComponent<Rigidbody>().isKinematic = false;
            //Contador.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            activo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activo = false;
        }
    }
}
