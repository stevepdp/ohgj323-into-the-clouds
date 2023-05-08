using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    const float SPAWN_CLOUD_DELAY = 0f;
    const float SPAWN_CLOUD_REPEAT = 5f;

    [SerializeField] GameObject cloudPrefab;

    void Start()
    {
        InvokeRepeating("SpawnCloud", SPAWN_CLOUD_DELAY, SPAWN_CLOUD_REPEAT);
    }

    void SpawnCloud()
    {
        Instantiate(cloudPrefab);
    }
}
