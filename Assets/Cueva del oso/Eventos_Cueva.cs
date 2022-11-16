using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventos_Cueva : MonoBehaviour
{
    [SerializeField] private UnityEvent TriggerEnter;
    [SerializeField] private UnityEvent TriggerExit;
    [SerializeField] private UnityEvent CollisionEnter;
    [SerializeField] private UnityEvent CollisionExit;

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            TriggerEnter.Invoke();
        }

        if (other.transform.tag == "Oso")
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            CollisionEnter.Invoke();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            CollisionExit.Invoke();
        }
    }


}
