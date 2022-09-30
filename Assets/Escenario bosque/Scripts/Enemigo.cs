using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemigo : MonoBehaviour
{

    public Transform TransformPlayer;
    public float Speed;


    void Update()
    {
        distanciaEnemy();

    }

    void distanciaEnemy()
    {
        
            Debug.Log("Ha aparecido un enemigo");
            VelocidadEnemy();
            LookAtPlayer();
        
    }

    void VelocidadEnemy()
    {
        transform.position = Vector3.Lerp(transform.position, TransformPlayer.position, Speed * Time.deltaTime);
    }

    void LookAtPlayer()
    {
        transform.LookAt(TransformPlayer);

    }

}
