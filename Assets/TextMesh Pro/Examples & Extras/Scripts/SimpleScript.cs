using UnityEngine;

public class luzuTvController : MonoBehaviour
{
    public Light luzuTvLight; // Referencia a la luz que queremos controlar

    private bool isLuzuTvOn = true; // Variable para rastrear el estado de la luz

    private void Start()
    {
        // Asegúrate de que la luz esté encendida al principio
        luzuTvLight.enabled = true;
    }

    // Método para cambiar el estado de la luz
    public void ToggleLuzuTv()
    {
        isLuzuTvOn = !isLuzuTvOn;
        luzuTvLight.enabled = isLuzuTvOn;
    }
}

