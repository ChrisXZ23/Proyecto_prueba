using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;




public class MovimientoOso : MonoBehaviour
{
    [SerializeField] private GameObject pointer;
    public NavMeshAgent EnemyNaveMesh;
    public Transform TransformPointer;
    public Animator animacion;
    void Start()
    {

    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, TransformPointer.position);

        if (dist <= 25)
        {
            SeguirMesh();
            animacion.SetBool("run", true);

        }
        else
        {
            animacion.SetBool("run", false);
        }

        if (dist < 8)
        {
            animacion.SetBool("run", false);

        }
        if (dist <= 8)
        {
            animacion.SetBool("ataque", true);

        }
        if (dist >= 8)
        {
            animacion.SetBool("ataque", false);
        }

    }

    void SeguirMesh()
    {
        EnemyNaveMesh.destination = pointer.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {

        }
    }
}
