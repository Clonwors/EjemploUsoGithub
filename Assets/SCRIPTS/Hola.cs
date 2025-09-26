using UnityEngine;

public class Hola : MonoBehaviour
{
    public string nombreDelObjeto = "pescado";
    //variable 
    int unidad = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("pescado");  
    }

    // Update is called once per frame
    void Update()
    {
        //Aumentar una unidad
        unidad = unidad + 1;
        //Mostramos
        Debug.Log(nombreDelObjeto + " en el update" + unidad);
    }
}
