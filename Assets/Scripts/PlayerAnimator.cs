using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private PlayerControl playerControl;

    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        playerControl = GetComponent<PlayerControl>();
    }

    private void Update()
    {
        ChangeXAnimtorAxis();
        Jump();
        isGrounded();
    }

    private void ChangeXAnimtorAxis()
    {
        playerAnimator.SetFloat("x", playerControl.Horizontal);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnimator.SetTrigger("Jump");
        }
    }

    public void Fall()
    {
        playerAnimator.SetTrigger("Fall");
    }

    public void CollisionBarrier()
    {
        playerAnimator.SetTrigger("Collision");
    }

    private void isGrounded()
    {
        playerAnimator.SetBool("IsGround", playerControl.ÑharacterController.isGrounded);
    }
}
