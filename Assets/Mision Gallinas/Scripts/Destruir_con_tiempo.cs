using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir_con_tiempo : MonoBehaviour
{

    public float tiempo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, tiempo);


    }
}
