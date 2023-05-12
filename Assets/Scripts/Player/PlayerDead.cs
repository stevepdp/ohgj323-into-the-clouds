using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void OnEnable()
    {
        Player.OnPlayerFalling += SetFallAnim;
    }

    void OnDisable()
    {
        Player.OnPlayerFalling -= SetFallAnim;
    }

    void SetFallAnim()
    {
        if (animator != null)
            animator.SetBool("PlayerFalling", true);
    }
}
