using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TranscionParFinal : MonoBehaviour
{
    private Animator TranscionAnim;

    void Start()
    {
        TranscionAnim = GetComponent<Animator>();
    }

    public void LoadScene(string scene)
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(Transiciona(scene));
        }

    }


    IEnumerator Transiciona(string scene)
    {
        TranscionAnim.SetTrigger("salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(5);
    }
}

