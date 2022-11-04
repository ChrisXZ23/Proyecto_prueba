using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transicionaplicar : MonoBehaviour
{
    private Animator TranscionAnim;

    void Start()
    {
        TranscionAnim = GetComponent<Animator>();
    }

    public void LoadScene(string scene)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Transiciona(scene));
        }
            
    }


    IEnumerator Transiciona(string scene)
    {
        TranscionAnim.SetTrigger("salida");
        yield return new WaitForSeconds(1);
    }
}
