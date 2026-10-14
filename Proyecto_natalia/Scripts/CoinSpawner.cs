// Autora: Natalia Gámez Barea
// Data: 14/10/2026
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private int count = 5;
    [SerializeField] private float range = 5f;

    void Start()
    {
        // Instancia les monedes en posicions aleatòries
        for (int i = 0; i < count; i++)
        {
            float x = Random.Range(-range, range);
            float z = Random.Range(-range, range);

            Vector3 position = new Vector3(x, 1f, z);

            Instantiate(coinPrefab, position, Quaternion.identity);
        }
    }
}
