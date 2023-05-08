using UnityEngine;

public class CoinSpawner : MonoBehaviour, ISpawnable
{
    const float SPAWN_DELAY = 2f;
    const float SPAWN_REPEAT = 6f;

    [SerializeField] GameObject coinPrefab;

    public void Start()
    {
        InvokeRepeating("Spawn", SPAWN_DELAY, SPAWN_REPEAT);
    }

    public void Spawn()
    {
        Instantiate(coinPrefab);
    }
}
