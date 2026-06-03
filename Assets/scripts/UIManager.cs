using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoPuntos;

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

    public void pararT()
    {
        corriendo = false;
    }

    public void UpdateScore(int score)
    {
        if(score < 3)
        {
            textoPuntos.text = "Score: " + score;
        }
        else
        {
            textoPuntos.text = "Ganaste!";
            pararT();
        }
    }
}