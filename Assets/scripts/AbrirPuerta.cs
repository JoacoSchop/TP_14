using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public bool estaAbierta = false;
    public float gradosDeApertura = 90f;
    public float velocidad = 2f;

    private Quaternion rotacionCerrada;
    private Quaternion rotacionAbierta;

    void Start()
    {
        // Guarda la rotación inicial de la puerta cerrada
        rotacionCerrada = transform.rotation;
        // Calcula la rotación que tendrá al abrirse
        rotacionAbierta = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + gradosDeApertura, transform.eulerAngles.z);
    }

    void Update()
    {
        // Mueve suavemente la puerta hacia su estado actual
        if (estaAbierta)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionAbierta, Time.deltaTime * velocidad);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionCerrada, Time.deltaTime * velocidad);
        }
    }

    // Método que llamaremos desde el jugador para abrir/cerrar
    public void Interactuar()
    {
        estaAbierta = !estaAbierta;
    }
}



