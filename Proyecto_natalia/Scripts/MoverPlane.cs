// Autora: Natalia Gámez Barea
// Data: 14/10/2026
using UnityEngine;

public class MoverPlane : MonoBehaviour
{
    public float speed = 2f;
    public float range = 5f;

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        float moviment = Mathf.PingPong(Time.time * speed, range);

        transform.position = posicionInicial + Vector3.right * moviment;
    }
}