using UnityEngine;
using TMPro;

public class Recolector : MonoBehaviour
{
    public int puntos = 0;

    public TextMeshProUGUI textoPuntos;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);

            puntos++;

            textoPuntos.text = "Score: " + puntos;

            Debug.Log ("se recolecto obejto con exito");
        }
    }
}