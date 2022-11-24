using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class MovimientoOso : MonoBehaviour
{
    [SerializeField] private GameObject pointer;
    public NavMeshAgent EnemyNaveMesh;
    public Transform TransformPointer;
    public Animator animacion;


    public GameObject ataque1;
    public GameObject ataque2;
    public GameObject GameOver;
    public GameObject particulagolpe1;
    public GameObject particulagolpe2;
    public Text mensajegolpe;


    public GameObject fondoHP;
    public Image hpEnemy;
    [SerializeField] private float vidaEnemy;
    public GameObject audiocorriendoOso;
    public GameObject audioheridoOso;
    public GameObject audioheridoOso2;
    public GameObject audioOsocerca;

    public GameObject dRoca;
    public GameObject salidaC2;
    public GameObject misionCompleta;
    public GameObject audioPelea;
    public GameObject audioCompletado;
    public GameObject audiocueva;

    



    



    void Update()
    {
        

        //vidaosoMenos();
        distanciaEnemigo();
        
        
    }

    void SeguirMesh()
    {
        EnemyNaveMesh.destination = pointer.transform.position;

        
    }

    void distanciaEnemigo()
    {
        float dist = Vector3.Distance(transform.position, TransformPointer.position);
        if (dist >= 8)
        {
            SeguirMesh();
            animacion.SetBool("run", true);
            GameOver.SetActive(false);


        }
      

        if (dist >= 7)
        {
            SeguirMesh();
            animacion.SetBool("walk", true);
            audiocorriendoOso.SetActive(false);
        }


        if (dist <= 4)
        {

            animacion.SetBool("ataque", true);
            animacion.SetBool("run", false);
            GameOver.SetActive(true);
            audioOsocerca.SetActive(true);
            audiocorriendoOso.SetActive(false);


        }
        if (dist >= 5)
        {
            SeguirMesh();
            animacion.SetBool("ataque", false);
            GameOver.SetActive(false);
            audioOsocerca.SetActive(false);


        }


    }

    public void vidaOso1()
    {
        hpEnemy.fillAmount = vidaEnemy / 100;
        mensajegolpe.text = "Golpea con click izquierdo";

        if (Input.GetMouseButtonDown(0))
        {
            
            vidaEnemy -= 10;
            ataque1.SetActive(false);
            ataque2.SetActive(true);
            vidaosoMenos();
            audioheridoOso.SetActive(true);
            audioheridoOso2.SetActive(false);

            particulagolpe1.SetActive(true);
            particulagolpe2.SetActive(false);


        }
    }

    public void vidaOso2()
    {
        hpEnemy.fillAmount = vidaEnemy / 100;
        mensajegolpe.text = "Golpea con click izquierdo";

        if (Input.GetMouseButtonDown(0))
        {
            
            vidaEnemy -= 10;
            ataque2.SetActive(false);
            ataque1.SetActive(true);
            vidaosoMenos();
            audioheridoOso2.SetActive(true);
            audioheridoOso.SetActive(false);

            particulagolpe2.SetActive(true);
            particulagolpe1.SetActive(false);
        }
    }




    void vidaosoMenos()
    {
        if(vidaEnemy == 0)
        {

            ataque1.SetActive(false);

            ataque2.SetActive(false);

            fondoHP.SetActive(false);

            animacion.SetBool("death", true);
            EnemyNaveMesh.isStopped = true;

            dRoca.SetActive(false);
            misionCompleta.SetActive(true);

            audioCompletado.SetActive(true);
            audiocueva.SetActive(true);
            audioPelea.SetActive(false);
            salidaC2.SetActive(true);

            audiocorriendoOso.SetActive(false);
            audioOsocerca.SetActive(false);
            audioheridoOso.SetActive(true);
            audioheridoOso2.SetActive(true);
            mensajegolpe.text = "Sal de la cueva";
        }
    }




}
