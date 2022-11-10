using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource Puerta;

    public void AbriendoPuerta()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Puerta.Play();
        }
    }
}
