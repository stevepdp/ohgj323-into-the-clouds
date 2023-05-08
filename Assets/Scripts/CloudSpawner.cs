using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;
    private bool _keepSpawning = true;

    void Start()
    {
        StartCoroutine(GetNextCloud());
    }

    IEnumerator GetNextCloud()
    {
        while (_keepSpawning)
        {
            yield return new WaitForSeconds(Random.Range(2f, 5f));
            Instantiate(cloudPrefab);
        }
    }
}
