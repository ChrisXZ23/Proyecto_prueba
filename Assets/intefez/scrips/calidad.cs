using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class calidad : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int calidadBase;

    // Start is called before the first frame update
    void Start()
    {
        calidadBase = PlayerPrefs.GetInt("numeroDeCalidad", 2);
        dropdown.value = calidadBase;
        AjustarCalidad();
    }

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        calidadBase = dropdown.value;
    }
}
