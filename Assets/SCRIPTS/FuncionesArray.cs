using UnityEngine;

public class FuncionesArray : MonoBehaviour
{
    [SerializeField]
    int[] notasAlumnoPrimerTrimestre;
    
    [SerializeField]
    int[] notasAlumnoSegundoTrimestre;

    [SerializeField]
    int[] notasAlumnoTercerTrimestre;
    //El Array sirve para tener varios datos iguales en una lista
    //Se puede acceder de manera directa a cualquier elemento
    //El primer elemento es el numero 0

    void Start()
    {
        MostrarArray(notasAlumnoSegundoTrimestre);
        Debug.Log("Nota más alta del primer trimestre " + NotaMayor(notasAlumnoPrimerTrimestre));
        Debug.Log("Nota más alta del segundo trimestre " + NotaMayor(notasAlumnoSegundoTrimestre));
        Debug.Log("Nota más baja del primer trimestre " + NotaMenor(notasAlumnoPrimerTrimestre));
        Debug.Log("Nota más baja del segunfo trimestre " + NotaMenor(notasAlumnoSegundoTrimestre));
        Debug.Log("Nota media del primer trimestre " + CalculaMedia(notasAlumnoPrimerTrimestre));
    }
    /// <summary>
    /// Funcion que muestra en la consola todos los valores del array
    /// </summary>
    /// <param name="notasAlumno">Array con notas de un alumno en un trimestre</param>
    void MostrarArray(int[] notasAlumno)
    {
        //Cambiar el Debug.Log(i) para que se muestren las notas
        //que tenemos en el Array
        //NotasAlumno[indice] me permite ver la nota de ujn examen

        for (int i = 0; i < notasAlumno.Length; i++)
        {
            //Debug.Log(notasAlumno[i]);
        }
    }
    int NotaMayor(int[] notasAlumno)
    {
        int notaMasAlta = 0;
        //Debug.Log("Inicio de la busqueda de la nota mas alta ahora mismo la nota es " + notaMasAlta);
        for (int i = 0; i < notasAlumno.Length; i++)
        {
            //Debug.Log(i + "Compruebo" + notasAlumno[i] + " >" + notaMasAlta + "?");
            if (notasAlumno[i] > notaMasAlta)
            {

                //Debug.Log("Ahora cambio nota mas alta " + notaMasAlta + "por " + notasAlumno[i]);
                notaMasAlta = notasAlumno[i];
            }
        }

        return notaMasAlta;
    }
    int NotaMenor(int[] notasAlumno)
    {
        int notaMasBaja = 10 ;
        for (int i = 0; i < notasAlumno.Length; i++)
        {

            if (notasAlumno[i] < notaMasBaja)
            {
                notaMasBaja = notasAlumno[i];
            }
        }

        return notaMasBaja;
    }
    float CalculaMedia(int[] notasAlumno)
    {
        int suma = 0;
        for (int i = 0; i < notasAlumno.Length; i++)
        {
            suma = suma + notasAlumno[i];
        }
        float media = (float)suma / notasAlumno.Length;

        return media;
    }
}
