using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    [SerializeField] protected GameObject prefab;
    protected float spawnDelay;
    protected float spawnRepeat;

    void Start()
    {
        SpawnerSetup();
    }

    void SpawnerSetup()
    {
        if (prefab != null)
            InvokeRepeating("Spawn", spawnDelay, spawnRepeat);
    }

    void Spawn()
    {
        Instantiate(prefab);
    }
}