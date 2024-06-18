using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jump = 1;
    [SerializeField] private float gravity = -9.8f;

    private Vector3 direction;
    private Vector3 velocity;

    public CharacterController ÑharacterController { get; private set; }
    public float Horizontal {  get; private set; }

    private void Awake()
    {
        ÑharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (!GameOver.gameOver)
        {
            GetAxis();
            SetDirection();
            Jump();
            MoveCharacter();
        }
        Gravity();
    }

    private void Gravity()
    {
        velocity.y += gravity * Time.deltaTime;
        ÑharacterController.Move(velocity * Time.deltaTime);
    }

    private void MoveCharacter()
    {
        ÑharacterController.Move(direction * (speed * Time.deltaTime));
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ÑharacterController.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }
    }

    private void SetDirection()
    {
        direction = transform.forward + transform.right * Horizontal;
    }

    private void GetAxis()
    {
        Horizontal = Input.GetAxis("Horizontal");
    }
}
