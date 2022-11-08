using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(-9.789f, 0.08f, -7.764f);
    }

}
