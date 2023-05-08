using UnityEngine;

public class Cloud : MonoBehaviour
{
    const float DESPAWN_XPOS = -9.48f;
    const float MOVE_SPEED = 1f;
    const float SPAWN_XPOS = 10.61f;
    const float SPAWN_YPOS_MIN = 3.24879f;
    const float SPAWN_YPOS_MAX = 0f;

    void Start()
    {
        SetPosition();
    }

    void Update()
    {
        MoveCloud();
    }

    void MoveCloud()
    {
        transform.Translate(-Vector2.right * MOVE_SPEED * Time.deltaTime);

        if (transform.position.x <= DESPAWN_XPOS)
            Destroy(this.gameObject);

        // TODO: consider a pool
    }

    void SetPosition()
    {
        transform.position = new Vector2(SPAWN_XPOS, Random.Range(SPAWN_YPOS_MIN, SPAWN_YPOS_MAX));
    }
}
