using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool _playerIsDead = false;
    public bool playerIsFalling = false;
    private float _moveSpeed = 5f;

    private void Awake()
    {
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
        Debug.unityLogger.logEnabled = false;
#endif
    }

    void Update()
    {
        PlayerMove();
        KillPlayer();
    }

    void PlayerMove()
    {
        if (this.playerIsFalling)
        {
            transform.Translate(-Vector2.up * 2f * Time.deltaTime);
        }

        if (!this.playerIsFalling && !_playerIsDead)
        {
            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * _moveSpeed * Time.deltaTime, 0f, 0f));
            }
        }
    }

    public void ReleasePlayer()
    {
        this.playerIsFalling = true;
    }

    public void KillPlayer()
    {
        if (transform.position.y >= 6f)
        {
            // gameover
            _playerIsDead = true;
            Destroy(this.gameObject);
            Debug.Log("Player destroyed");
        }
    }
}
