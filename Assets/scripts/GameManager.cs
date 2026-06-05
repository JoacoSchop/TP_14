using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
public TextMeshProUGUI textoCronometro;

    private float tiempo = 60f;
 public bool corriendo = true;

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.R))
    {
        tiempo = 20f;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    if (corriendo)
    {
        tiempo -= Time.deltaTime;
    }

    textoCronometro.text = tiempo.ToString("F2");
}

    public void pararT(){
        corriendo = false;
    }
}
