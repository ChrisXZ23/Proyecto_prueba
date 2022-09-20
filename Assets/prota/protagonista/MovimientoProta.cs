using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProta : MonoBehaviour
{
    public float velocidad;
    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        transform.Translate(0, Input.GetAxis("Jump") * fuerza, 0);
    }
}
