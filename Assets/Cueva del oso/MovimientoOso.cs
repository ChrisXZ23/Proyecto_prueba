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
        

        if (dist >= 13)
        {
            SeguirMesh();
            animacion.SetBool("run", true);

        }

        if(dist <= 12)
        {
            SeguirMesh();
            animacion.SetBool("walk", true);
        }


        if (dist <= 7)
        {
            SeguirMesh();
            animacion.SetBool("ataque", true);
            animacion.SetBool("run", false);


        }
        if (dist >= 8)
        {
            SeguirMesh();
            animacion.SetBool("ataque", false);
            
        }

    }

    void SeguirMesh()
    {
        EnemyNaveMesh.destination = pointer.transform.position;
    }

 


}
