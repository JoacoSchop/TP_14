using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPuerta : MonoBehaviour
{
    public float distanciaDeInteraccion = 5f;
    public LayerMask capaDeLaPuerta; // Útil para optimizar (opcional)

    void Update()
    {
        // Crea un rayo desde el centro de la cámara hacia adelante
        Ray rayo = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // Dibuja el rayo en la pestaña Scene para que puedas verlo (opcional)
        Debug.DrawRay(transform.position, transform.forward * distanciaDeInteraccion, Color.red);

        // Si el rayo golpea un objeto y presionas la tecla "E"
        if (Physics.Raycast(rayo, out hit, distanciaDeInteraccion))
        {
            // Verificamos si lo que miramos tiene el script AbridorPuerta
            AbrirPuerta puerta = hit.collider.GetComponentInParent<AbrirPuerta>();

            if (puerta != null)
            {
                // Aquí puedes mostrar un texto en pantalla: "Presiona E para abrir"
                
                if (Input.GetKeyDown(KeyCode.E))
                {
                    puerta.Interactuar();
                }
            }
        }
    }
}


