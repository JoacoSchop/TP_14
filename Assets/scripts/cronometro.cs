using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cronometro : MonoBehaviour
{
public TextMeshProUGUI textoCronometro;

    private float tiempo = 0f;
 public bool corriendo = true;

    void Update()
    {
       
        if (corriendo)
        {
            tiempo += Time.deltaTime;
        }

        textoCronometro.text = tiempo.ToString("F2");
    }

    public void pararT(){
        corriendo = false;
    }
}
