using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
        Debug.unityLogger.logEnabled = false;
#endif
        transform.position = new Vector2(Random.Range(-8.36f, 8.36f), -2.9f);
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(SelfDestruct());   
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {   
            Destroy(this.gameObject);
        }
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(3f);
       
        if (player != null)
        {
            var playerRef = player.GetComponent<Player>();
            if (!playerRef.playerIsFalling) Debug.Log("Coin self destructed. Killing player...");
            playerRef.ReleasePlayer();
        }
        Destroy(this.gameObject);
    }
}
