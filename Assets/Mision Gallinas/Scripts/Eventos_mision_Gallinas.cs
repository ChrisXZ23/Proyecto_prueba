using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventos_mision_Gallinas : MonoBehaviour
{
    [SerializeField] private UnityEvent TriggerEnter;
    [SerializeField] private UnityEvent TriggerExit;

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            TriggerEnter.Invoke();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            TriggerExit.Invoke();
        }
    }


}
