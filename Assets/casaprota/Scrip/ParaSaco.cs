using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaSaco : MonoBehaviour
{
    public GameObject Saco;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RecogerSaco();
    }

    public void RecogerSaco()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Saco);
            Debug.Log("Haz obtenido el saco");
            Debug.Log("Sal de la casa");
        }
    }
}
