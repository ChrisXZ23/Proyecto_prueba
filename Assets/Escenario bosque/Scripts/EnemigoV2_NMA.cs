using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoV2_NMA : MonoBehaviour
{
    [SerializeField] private GameObject jugador;
    public NavMeshAgent EnemyNavMesh;
    public Transform transformJugador;
    void Start()
    {
        //EnemyNavMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(transform.position, transformJugador.position);

        if (dist < 20)
        {
            EnemyNavMesh.destination = jugador.transform.position;
        }

    }
}
