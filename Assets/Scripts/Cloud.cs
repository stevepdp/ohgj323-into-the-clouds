using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private void Awake()
    {
        transform.position = new Vector2(10.61f, Random.Range(3.24879f, 0f));
    }

    void Update()
    {
        transform.Translate(-Vector2.right * 1f * Time.deltaTime);

        if (transform.position.x <= -9.48f)
        {
            Destroy(this.gameObject);
        }
    }
}
