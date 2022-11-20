using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Protagonista : MovimientoProta
{
    Animator animator;
    int isWalkingHash;
    int isrunningHash;

    public Image Stamina;
    [SerializeField] private float vStamina;

    public Image hpPlayer;
    [SerializeField] private float vidaP;
    public GameObject quietoOver;
    [SerializeField] private GameObject PointP;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("IsWalking");
        isrunningHash = Animator.StringToHash("IsRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isrunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetButton("Horizontal");
        bool forwardPressedL = Input.GetButton("Vertical");
        bool walkPressed = forwardPressed || forwardPressedL;
        bool RunPressed = Input.GetKey("left shift");

        if (!isWalking && walkPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !walkPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if (!isRunning && (walkPressed && RunPressed))
        {
            animator.SetBool(isrunningHash, true);
        }
        

        if (isRunning && (!walkPressed || !RunPressed))
        {
            animator.SetBool(isrunningHash, false);
            
        }

        if (RunPressed && walkPressed)
        {
            StaminaV();
            velocidadRS();
        }

        if (!RunPressed && !walkPressed)
        {
            StaminaVmas();
        }
        if (!RunPressed && walkPressed)
        {
            StaminaVmas();
        }
        

    }



    void StaminaVmas()
    {
        Stamina.fillAmount = vStamina / 100;
        vStamina++;
        
        if (vStamina >= 100)
        {
            vStamina = 100f;
            
        }
        if (vStamina >= 10)
        {
            //velocidadT();
        }

        
            
    }

    void StaminaV()
    {
        Stamina.fillAmount = vStamina / 100;
        if (Input.GetKey("left shift"))
        {
            vStamina-=0.1f;
            
        }
        if (vStamina <= 0)
        {
            vStamina = 0;
            
        }
        



    }

    void velocidadRS()
    {
        if (vStamina >= 11)
        {
            velocidadT();
            animator.SetBool(isrunningHash, true);
        }
        if (vStamina <= 10)
        {
            VelocidadmenosT();
            animator.SetBool(isrunningHash, false);
        }
    }


    public void vidaPlayer()
    {
        hpPlayer.fillAmount = vidaP / 100;

        vidaP -= 8;
        animator.SetBool("help", true);
 

        if (vidaP <= 0)
        {
            vidaP = 0;
            SceneManager.LoadScene(6);
        }

        if(vidaP <= 10)
        {
            animator.SetBool("deathP", true);
            quietoOver.transform.position = PointP.transform.position;
        }
        

    }

    public void golpeP()
    {
        animator.SetBool("help", false);
    }

    public void ataqueP()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("attack", true);

            if (Input.GetMouseButton(0))
            {
                animator.SetBool("attack", false);

            }

        }

    }

    public void llevarcarreta()
    {
        animator.SetBool("carreta", false);
    }
    public void llevarMaiz()
    {
        animator.SetBool("agarrar", false);
    }

}
