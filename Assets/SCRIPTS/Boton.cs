using UnityEngine;

public class Boton : MonoBehaviour
{
    public void AccionDelBoton()
    {
        Debug.Log("BOTÓN PULSADO");
    }

    public void CambiarEstado()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
