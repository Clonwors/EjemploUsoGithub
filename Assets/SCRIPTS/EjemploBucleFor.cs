using Unity.Burst;
using Unity.VisualScripting;
using UnityEngine;

public class EjemploBucleFor : MonoBehaviour
{
    [SerializeField]
    GameObject[] limitesEscenario;
    
    [SerializeField]

    void Start()
    {
        float minX = limitesEscenario[0].transform.position.x;
        float maxX = limitesEscenario[0].transform.position.x;

        float minZ = limitesEscenario[0].transform.position.z;
        float maxZ = limitesEscenario[0].transform.position.z;

        for (int i = 0; i < limitesEscenario.Length; i++)
        {
            limitesEscenario[i].gameObject.SetActive(false);

            //comprobar minimo de x
            if (minX > limitesEscenario[i].transform.position.x)
            {
                minX = limitesEscenario[i].transform .position.x;
            }
            //comprobar maximo de x
            if (maxX < limitesEscenario[i].transform.position.x)
            {
                maxX = limitesEscenario[i].transform .position.x;
            }
            //comprobar minimo de z
            if (minZ > limitesEscenario[i].transform.position.z)
            {
                minZ = limitesEscenario[i].transform .position.z;
            }
            //comprobar maximo de z
            if (maxZ < limitesEscenario[i].transform.position.z)
            {
                maxZ = limitesEscenario[i].transform .position.z;
            }
        }
        for (int i = 0; i < 10;i++)
        {
            Vector3 pos = new Vector3(Random.Range(minX, maxX), -2,5075f, Random.Range(minZ, maxZ));
            Instantiate(prefabs.[Random.Range(0, prefabs.Length)], pos, Quaternion.identity);
        }
        //temer acceso a ujn array con los prefabs
        //crear 10 gameobjets 



    }
    
}
