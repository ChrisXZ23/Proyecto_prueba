using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transcion : MonoBehaviour
{
    private Animator TranscionAnim;

    void Start()
    {
        TranscionAnim = GetComponent<Animator>();
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(Transiciona(scene));

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    IEnumerator Transiciona(string scene)
    {
        TranscionAnim.SetTrigger("salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
