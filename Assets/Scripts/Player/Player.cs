using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static event Action OnGameOver;
    public static event Action OnPlayerFalling;

    const byte CEILING = 6;
    const float FALL_SPEED = 2f;

    bool playerIsDead;
    bool playerIsFalling;

    public bool PlayerIsDead
    {
        get { return playerIsDead; }
        set { playerIsDead = value; }
    }

    public bool PlayerIsFalling
    {
        get { return playerIsFalling; }
        set { playerIsFalling = value; }
    }

    void Update()
    {
        PlayerFall();
    }

    void OnEnable()
    {
        Coin.OnCoinMissed += PlayerRelease;
        OnGameOver += GameOver;
    }

    void OnDisable()
    {
        Coin.OnCoinMissed -= PlayerRelease;
        OnGameOver -= GameOver;
    }

    void PlayerRelease()
    {
        playerIsFalling = true;
    }

    void PlayerFall()
    {
        if (playerIsFalling && !playerIsDead)
        {
            transform.Translate(-Vector2.up * FALL_SPEED * Time.deltaTime);
            OnPlayerFalling?.Invoke();
        }
            
        
        if (playerIsFalling && !playerIsDead && transform.position.y > CEILING)
        {
            playerIsDead = true;
            playerIsFalling = false;
            OnGameOver?.Invoke();
        }
    }

    void GameOver()
    {
        Destroy(gameObject);
    }
}
