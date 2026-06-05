using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoPuntos;
    public TextMeshProUGUI textoFinal;
    public TextMeshProUGUI textoSub;
    public Image panel;

    private float tiempo = 30f;
    public bool corriendo = true;

    void Update()
    {
        if (corriendo)
        {
            tiempo -= Time.deltaTime;
        }

        textoCronometro.text = tiempo.ToString("F2");
        if(tiempo <= 0f){
            textoPuntos.text = "";
            textoFinal.text = "Perdiste";
            textoSub.text = "Apreta R para volver a empezar.";
            Color c = Color.red;
            c.a = 0.8f;
            panel.color = c;
            pararT();
            Time.timeScale = 0f;
            tiempo = 30f;
        }
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
            textoPuntos.text = "";
            textoFinal.text = "Ganaste!";
            textoSub.text = "Apreta R para volver a empezar.";
            Color c = Color.green;
            c.a = 0.8f;
            panel.color = c;
            pararT();
            Time.timeScale = 0f;
        }
    }
}