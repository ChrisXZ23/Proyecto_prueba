using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaOpciones : MonoBehaviour
{
    public GameObject Activasion;
    public GameObject ApagarAnterior;

    public void ActicarOpciones()
    {
        Activasion.SetActive(true);
        ApagarAnterior.SetActive(false);
    }

    public void ApagarOpciones()
    {
        Activasion.SetActive(false);
        ApagarAnterior.SetActive(true);
    }

    public void SolMenuInicial()
    {
        Activasion.SetActive(true);
    }

    public void Apagar()
    {
        Activasion.SetActive(false);
    }
}
