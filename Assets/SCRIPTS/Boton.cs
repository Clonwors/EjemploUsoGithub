using UnityEngine;

public class Boton : MonoBehaviour
{
    public void AccionDelBoton()
    {
        Debug.Log("BOT�N PULSADO");
    }

    public void CambiarEstado()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
