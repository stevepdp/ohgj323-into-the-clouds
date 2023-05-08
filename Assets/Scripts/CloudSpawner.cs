using UnityEngine;

public class CloudSpawner : MonoBehaviour, ISpawnable
{
    const float SPAWN_DELAY = 0f;
    const float SPAWN_REPEAT = 5f;

    [SerializeField] GameObject cloudPrefab;

    public void Start()
    {
        InvokeRepeating("Spawn", SPAWN_DELAY, SPAWN_REPEAT);
    }

    public void Spawn()
    {
        Instantiate(cloudPrefab);
    }
}
