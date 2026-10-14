// Autora: Natalia Gámez Barea
// Data: 14/10/2026
using UnityEngine;

public class SolucioMoverPlaneyJugador : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            transform.SetParent(collision.transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            transform.SetParent(null);
        }
    }
}