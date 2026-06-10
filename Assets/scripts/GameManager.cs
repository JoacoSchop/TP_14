using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float tiempo = 30f;
    public bool corriendo = true;
    public bool jugando = true;
    private UIManager uiManager;

    void Awake()
    {
        jugando = true;
        uiManager = FindObjectOfType<UIManager>();
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && jugando == false)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (corriendo)
        {
            tiempo -= Time.deltaTime;

            if (tiempo <= 0f)
            {
                tiempo = 0f;
                pararT();
                uiManager.MostrarDerrota();
            }
        }

        uiManager.UpdateTimer(tiempo); 
    }

    public void pararT()
    {
        corriendo = false;
        Time.timeScale = 0f;
    }
}