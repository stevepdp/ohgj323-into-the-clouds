public class CloudSpawner : Spawner
{
    const float CLOUD_SPAWN_DELAY = 0f;
    const float CLOUD_SPAWN_REPEAT = 5f;

    void Awake()
    {
        spawnDelay = CLOUD_SPAWN_DELAY;
        spawnRepeat = CLOUD_SPAWN_REPEAT;
    }
}
