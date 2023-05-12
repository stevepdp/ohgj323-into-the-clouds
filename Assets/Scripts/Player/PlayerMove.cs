using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    const float MOVE_SPEED = 5f;
    const float H_AXIS_THRESHOLD = .5f;

    Player player;
    Animator playerAnim;
    bool isMoving;

    void Awake()
    {
        player = GetComponent<Player>();
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (player != null && !player.PlayerIsFalling && !player.PlayerIsDead)
        {
            float hInput = Input.GetAxisRaw("Horizontal");

            if (hInput > H_AXIS_THRESHOLD || hInput < -H_AXIS_THRESHOLD)
            {
                transform.Translate(new Vector3(hInput * MOVE_SPEED * Time.deltaTime, 0, 0));
                if (playerAnim != null)
                {
                    isMoving = true;
                    playerAnim.SetBool("PlayerMoving", isMoving);
                }
            }
            else
            {
                isMoving = false;
                playerAnim.SetBool("PlayerMoving", isMoving);
            }
        }
    }
}
