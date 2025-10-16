using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class StarBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject objeto;
    [SerializeField]
    float animDuration = 0.75f;
    [SerializeField]
    LeanTweenType curvaMovimiento;
    [SerializeField]
    float animDurationScale = 0.4f;
    [SerializeField]
    LeanTweenType curvaEscala;
    [SerializeField]
    float animDurationRotation = 1f;

    void Start()
    {
        LeanTween.moveLocalY(objeto, 200f, animDuration).setEase(curvaMovimiento);
        //Deformar estrella antes de ejecutar el lean tween
        objeto.transform.localScale = new Vector3(1.0f, 2.0f, 1.0f);
        //Activar leantween animando escala
        LeanTween.scaleY(objeto, 5f, animDurationScale).setEase(curvaEscala).setOnComplete(AnimacionLatido);

    }
    
    void AnimacionLatido()
    {
        LeanTween.scale(objeto, Vector3.one * 1.5f, animDurationScale).setEaseInBounce().setOnComplete(AnimacionSpin);
    }

    void AnimacionSpin()
    {
        LeanTween.rotateZ(objeto, 99999f, animDurationRotation).setEase(curvaMovimiento);
    }
}
