using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventos : MonoBehaviour
{
    [SerializeField] private UnityEvent ColliderEnter;
    [SerializeField] private UnityEvent TriggerEnter;

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.transform.tag == "Player")
        {
            ColliderEnter.Invoke();
        }
    }

    private void OnTriggerStay(Collider Other)
    {
        if (Other.transform.tag == "Player")
        {
            TriggerEnter.Invoke();
        }
    }
}