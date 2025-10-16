using Unity.VisualScripting;
using UnityEngine;

public class CuboMovimiento : MonoBehaviour
{
    [SerializeField]
    GameObject cubo;
    [SerializeField]
    float animDuration = 0.5f;
    [SerializeField]
    LeanTweenType curvaMovimiento;
    [SerializeField]
    float animDurationScale = 1f;
    [SerializeField]
    float animDurationRotate = 1f;


    void Start()
    {
        //El cubo se mueve hacia abajo
        LeanTween.moveLocalZ(cubo, -80f, animDuration).setEase(curvaMovimiento).setOnComplete(AnimacionX);
    }

    void AnimacionX()
    {
        //El cubo se mueve hacia la derecha
        LeanTween.moveLocalX(cubo, 62f, animDuration).setEase(curvaMovimiento).setOnComplete(AnimacionZ2);
    }

    void AnimacionZ2()
    {
        //El cubo se mueve hacia arriba
        LeanTween.moveLocalZ(cubo, 71.15f, animDuration).setEase(curvaMovimiento).setOnComplete(AnimacionX2);
    }

    void AnimacionX2()
    {
        //El cubo se mueve hacia la izquierda
        LeanTween.moveLocalX(cubo, -65.6f, animDuration).setEase(curvaMovimiento).setOnComplete(AnimacionSpin);
    }

    void AnimacionSpin()
    {
        //El cubo gira de forma loca
        LeanTween.rotateX(cubo, 9999f, animDurationRotate).setEase(curvaMovimiento).setOnComplete(AnimacionSusto);
    }
    void AnimacionSusto()
    {
        LeanTween.moveX(cubo, 2.5f, animDuration).setEase(curvaMovimiento);
        LeanTween.moveY(cubo, 53.4f, animDuration).setEase(curvaMovimiento);
        LeanTween.moveZ(cubo, -91.5f, animDuration).setEase(curvaMovimiento);
        LeanTween.scaleZ(cubo, 100f, animDurationScale).setEase(curvaMovimiento);
        LeanTween.scaleX(cubo, 100f, animDurationScale).setEase(curvaMovimiento);
        LeanTween.scaleY(cubo, 100f, animDurationScale).setEase(curvaMovimiento).setOnComplete(AnimacionX);

    }
}
