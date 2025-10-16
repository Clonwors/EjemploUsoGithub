
using UnityEngine;

public class MovimientoAleatorioCubo : MonoBehaviour
{
    [SerializeField]
    Transform[] positions;
    
    [SerializeField]
    GameObject gameElement;
    
    [SerializeField]
    float timeAnimation = 0.75f;

    int arrayIndex;
    int elPosition;
    void Start()
    {
        arrayIndex = GenerateNumber();
        elPosition = arrayIndex;
        gameElement.transform.position = positions[arrayIndex].position;
        MoverInfinito();
    }

    void MoverInfinito()
    {
        arrayIndex = GenerateNumber();
        //Ejecutar en movimiento
        LeanTween.move(gameElement, positions[arrayIndex], 0.75f).setOnComplete(MoverInfinito);
    }
    int GenerateNumber()
    {
        int mum = Random.Range(0, positions.Length);
        while (mum == arrayIndex || mum == elPosition)
        {
            mum = Random.Range(0, positions.Length);
        }
        elPosition = arrayIndex;

        return mum;
    }
}
