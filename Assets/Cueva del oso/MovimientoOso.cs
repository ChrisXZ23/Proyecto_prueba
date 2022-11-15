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
    public Image hpEnemy;
    [SerializeField] private float vidaEnemy = 100;



    

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
            GameOver.SetActive(false);

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
            GameOver.SetActive(true);


        }
        if (dist >= 8)
        {
            SeguirMesh();
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
        SceneManager.LoadScene(6);
        
    }


    void vidaosoMenos()
    {
        if(vidaEnemy == 0)
        {
            Destroy(ataque1);
            Destroy(ataque2);
            Destroy(GameOver);
        }
    }



}
