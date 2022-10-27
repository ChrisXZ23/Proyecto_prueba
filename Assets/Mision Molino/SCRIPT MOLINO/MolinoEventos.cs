using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MolinoEventos : MonoBehaviour
{
    [SerializeField] private UnityEvent TriggerExit;
    [SerializeField] private UnityEvent TriggerEnter;

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            TriggerExit.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            TriggerEnter.Invoke();
        }
    }
}
