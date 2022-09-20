using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarSaco : MonoBehaviour
{
    public GameObject DestruirSaco;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComandoSaco()
    {
        DestruirSaco.SetActive(true);
    }
}
