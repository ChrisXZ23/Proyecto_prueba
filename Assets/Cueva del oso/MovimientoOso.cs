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

    public GameObject fondoHP;
    public Image hpEnemy;
    [SerializeField] private float vidaEnemy;



    

    void Start()
    {

    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, TransformPointer.position);

        vidaosoMenos();

        if (dist <= 16)
        {
            SeguirMesh();
            animacion.SetBool("run", true);
            GameOver.SetActive(false);

        }

        if(dist <= 7)
        {
            
            animacion.SetBool("walk", true);
        }


        if (dist <= 5)
        {
            
            animacion.SetBool("ataque", true);
            animacion.SetBool("run", false);
            GameOver.SetActive(true);


        }
        if (dist >= 6)
        {
            
            animacion.SetBool("ataque", false);
            GameOver.SetActive(false);
            
        }

    }

    void SeguirMesh()
    {
        EnemyNaveMesh.destination = pointer.transform.position;
    }

    public void vidaOso1()
    {
        hpEnemy.fillAmount = vidaEnemy / 100;

        if (Input.GetMouseButtonDown(0))
        {
            
            vidaEnemy -= 10;
            ataque1.SetActive(false);
            ataque2.SetActive(true);
            vidaosoMenos();
        }
    }

    public void vidaOso2()
    {
        hpEnemy.fillAmount = vidaEnemy / 100;

        if (Input.GetMouseButtonDown(0))
        {
            
            vidaEnemy -= 10;
            ataque2.SetActive(false);
            ataque1.SetActive(true);
            vidaosoMenos();
        }
    }

    public void gameOver()
    {
        //SceneManager.LoadScene(6);
        
    }


    void vidaosoMenos()
    {
        if(vidaEnemy == 0)
        {
            //Destroy(ataque1);
            ataque1.SetActive(false);
            //Destroy(ataque2);
            ataque2.SetActive(false);
            //Destroy(GameOver);
            fondoHP.SetActive(false);

            animacion.SetBool("death", true);
        }
    }



}
