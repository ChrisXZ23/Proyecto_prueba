using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LacuraTrans : MonoBehaviour
{
    private Animator TranscionCura;

    void Start()
    {
        TranscionCura = GetComponent<Animator>();
    }

    public void CambioCura()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TransicionaCura();
        }
    }


    IEnumerator TransicionaCura()
    {
        TranscionCura.SetTrigger("salida");
        yield return new WaitForSeconds(1);
        
    }
}
