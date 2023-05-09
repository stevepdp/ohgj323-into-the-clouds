public class CoinSpawner : Spawner
{
    const float COIN_SPAWN_DELAY = 2f;
    const float COIN_SPAWN_REPEAT = 6f;

    void Awake()
    {
        spawnDelay = COIN_SPAWN_DELAY;
        spawnRepeat = COIN_SPAWN_REPEAT;
    }
}