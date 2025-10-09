using UnityEngine;

public class CreadorObjetos : MonoBehaviour
{
    [SerializeField]
    GameObject[] objetoQueVoyACrear;

    [SerializeField]
    int cantidadDeObjetos = 5;

    void Start()
    {
        Debug.Log(Random.Range(-3f, 3f));
        //Crear 5 veces el mismo objeto, cambiando su posicion de forma aleatoria

        for (int i = 0; i < cantidadDeObjetos; i++)
        {
            float posX = Random.Range(-5f, 6f);
            float posY = Random.Range(0f, 8f);
            float posZ = Random.Range(-7f, 13f);
            int numAleatorio = Random.Range(0, objetoQueVoyACrear.Length);
            Instantiate(objetoQueVoyACrear[numAleatorio], new Vector3(posX, posY, posZ), Quaternion.identity);
        }
    }


    void Update()
    {
        
    }
}
 