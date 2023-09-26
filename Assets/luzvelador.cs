using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ControlDeLuzDeVela : MonoBehaviour
{
    public Light velaLuz; // Referencia a la luz de la vela
    private bool luzEncendida = true; // Variable para rastrear el estado de la luz
    private XRGrabInteractable grabInteractable; // Referencia al XRGrabInteractable

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        // Asegúrate de que la luz de la vela esté encendida al principio
        velaLuz.enabled = luzEncendida;
    }

    // Método para cambiar el estado de la luz
    public void ToggleLuz()
    {
        // Verifica si el Velador está agarrado (grabbed) antes de cambiar la luz
        if (grabInteractable.isSelected)
        {
            luzEncendida = !luzEncendida;
            velaLuz.enabled = luzEncendida;
        }
    }
}
