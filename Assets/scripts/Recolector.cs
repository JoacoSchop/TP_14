using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Recolector : MonoBehaviour
{
    public int puntos = 0;

    private UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);

            puntos++;

            uiManager.UpdateScore(puntos);

            Debug.Log("Se agarro objeto con exito: " + puntos);
        }
    }
}