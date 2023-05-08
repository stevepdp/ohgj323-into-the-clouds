using System;
using Random = UnityEngine.Random;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Action OnCoinMissed;

    const float COIN_TIMEOUT = 3f;
    const float SPAWN_XPOS_MIN = -8.36f;
    const float SPAWN_XPOS_MAX = -SPAWN_XPOS_MIN;
    const float SPAWN_YPOS = -2.9f;

    void Start()
    {
        SetCoinXPos();
        Invoke("CoinMissed", COIN_TIMEOUT);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
    }

    void CoinMissed()
    {
        OnCoinMissed?.Invoke();
        Destroy(gameObject);
    }

    void SetCoinXPos()
    {
        transform.position = new Vector2(Random.Range(SPAWN_XPOS_MIN, SPAWN_XPOS_MAX), SPAWN_YPOS);
    }
}
