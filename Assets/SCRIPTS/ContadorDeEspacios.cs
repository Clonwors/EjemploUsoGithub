using UnityEngine;

public class ContadorDeEspacios : MonoBehaviour
{
    int vecesPulsado = 0;
    Rigidbody rb;
    public float fuerza = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rb.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
            vecesPulsado = vecesPulsado + 1;
        }
        //pulsando 10 veces
        if (vecesPulsado == 10)
        {
            Debug.Log("Pulsado 10 veces");
            vecesPulsado = 0;
        }
        else
        {
            Debug.Log("Veces pulsado = " + vecesPulsado);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entra en colision");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sale de colision");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Mantiene en colision");
    }
}
