using UnityEngine;
using TMPro;

public class LeanTweenEjemplo : MonoBehaviour
{
    [SerializeField]
    GameObject objeto;
    [SerializeField]
    float animationTime = 0.75f;
    [SerializeField]
    Vector3 newPosition = new Vector3(2.84f, 10f, -6.8f);
    [SerializeField]
    LeanTweenType curva;
    [SerializeField]
    TextMeshProUGUI textMuestra;

    Vector3 originalScale;
    //Que el texto del boton muestre agrandar o encoger en base a lo que se vaya a ejecutar
    private void Start()
    {
        originalScale = objeto.transform.localScale;
        textMuestra.text = "Agrandar";
    }
    public void AccionBoton()
    {
        if (LeanTween.isTweening(objeto) == false)
        {
            if (objeto.transform.localScale == originalScale)
            {
                LeanTween.scale(objeto, Vector3.one * 3f,animationTime). setEase(curva) ;
                textMuestra.text = "Encoger";
            }
            else
            {
                LeanTween.scale(objeto, originalScale, animationTime).setEase(curva);
                textMuestra.text = "Agrandar";
            }
        }
    }   
}