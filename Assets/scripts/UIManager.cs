using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoPuntos;
    public TextMeshProUGUI textoFinalWin;
    public TextMeshProUGUI textoFinalDerrota;
    public TextMeshProUGUI textoSub;
    public GameObject panelWin;
    public GameObject panelDerrota;
    private GameManager gameManager;

    void Awake()
    {
    gameManager = FindObjectOfType<GameManager>();
    }


    public void UpdateTimer(float tiempo)
    {
        textoCronometro.text = tiempo.ToString("F2");
    }

    public void MostrarDerrota()
    {
        textoPuntos.text = "";
        gameManager.jugando = false;
        Time.timeScale = 0;
        panelDerrota.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        if (score < 3)
        {
            textoPuntos.text = "Score: " + score;
        }
        else
        {
            textoPuntos.text = "";
            gameManager.jugando = false;
            Time.timeScale = 0;
            panelWin.SetActive(true);

        }
    }
}