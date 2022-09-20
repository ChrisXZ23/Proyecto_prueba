using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventosInterfaz : MonoBehaviour
{
    [SerializeField] private UnityEvent ColliderEnter;
    [SerializeField] private UnityEvent TriggerEnter;

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.transform.tag == "player")
        {
            ColliderEnter.Invoke();
        }
    }

    private void OnTriggerStay(Collider Other)
    {
        if (Other.transform.tag == "player")
        {
            TriggerEnter.Invoke();
        }
    }
}