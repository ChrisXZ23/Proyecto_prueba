using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleOpciones : MonoBehaviour
{
    public static singleOpciones Mantener;

    void awake()
    {
            Destroy(gameObject);
    }
}
