using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    private bool _keepMakingCoin = true;

    void Start()
    {
        StartCoroutine(GetNextCoin());
    }

    IEnumerator GetNextCoin()
    {
        while (_keepMakingCoin)
        {
            yield return new WaitForSeconds(Random.Range(2f, 6f));
            Instantiate(coinPrefab);
        }
    }
}
