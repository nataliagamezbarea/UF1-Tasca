// Autora: Natalia Gámez Barea
// Data: 14/10/2026
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
