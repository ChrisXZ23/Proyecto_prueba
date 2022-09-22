using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Gallinas : MonoBehaviour
{

    [SerializeField] private GameObject jugador;
    public NavMeshAgent GallinasNavMesh;
    public Transform transformJugador;


    void Start()
    {
        
    }

    
    void Update()
    {

        float dist = Vector3.Distance(transform.position, transformJugador.position);

        if (dist < 15)
        {

            GallinasNavMesh.destination = jugador.transform.position;
            
        }

    }

   

    

}
