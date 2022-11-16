using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SeguirProta : MonoBehaviour
{
    public Transform TransformPlayer;
    public float speed;
    public Animator animacion;
    public Text dialogosUI;
    public Text dialogosintUI;
    public GameObject CuadroD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distancia();
    }

    void Distancia()
    {
        float dist = Vector3.Distance(transform.position, TransformPlayer.position);

        if (dist <= 20)
        {
            LookAtPlayer();
            animacion.SetBool("run", false);
        }
        if (dist <= 14)
        {
            //CuadroD.SetActive(true);
            //dialogosUI.text = "HEY! te he estado buscando";
           // dialogosintUI.text = " ";
            SeguirLerp();
            LookAtPlayer();
            animacion.SetBool("run", true);
        }
        else
        {
            animacion.SetBool("run", false);
        }
        if (dist < 3)
        {
            speed = 0;
            animacion.SetBool("run", false);
            //CuadroD.SetActive(false);

        }
        else
        {
            speed = 0.8f;
        }
    }

    void SeguirLerp()
    {
        //transform.LookAt(TransformPlayer);
        transform.position = Vector3.Lerp(transform.position, TransformPlayer.position, speed * Time.deltaTime);
    }

    void LookAtPlayer()
    {
        transform.LookAt(TransformPlayer);
    }
}
