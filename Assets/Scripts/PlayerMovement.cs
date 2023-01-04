using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement vars")]
    [SerializeField] private float jumpForce;
    public bool isGrounded;

    [Header("Settings")]
    [SerializeField] private Transform groundColliderTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float jumpOffset;
    [SerializeField] private LayerMask groundMask;

    private Rigidbody2D rb;
    private Transform playerTransform;
    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Vector3 overLapCirclePosision = groundColliderTransform.position;
        isGrounded = Physics2D.OverlapCircle(overLapCirclePosision, jumpOffset, groundMask);
        if (isGrounded)
            anim.SetTrigger("EndOfJump");
        else
            anim.SetTrigger("Jump");
    }

    public void Move(float direction, bool isJumpButtonPressed) 
    {
        if (isJumpButtonPressed) 
        {
            Jump();
        }

        if(direction != 0) 
        {
            if (direction < 0) 
                playerTransform.localScale = new Vector3(-3, playerTransform.lossyScale.y, playerTransform.lossyScale.z);
            else if (direction > 0) 
                playerTransform.localScale = new Vector3(3, playerTransform.lossyScale.y, playerTransform.lossyScale.z);
        }
        
        if(Mathf.Abs(direction)> 0.01f) 
        {
            HorizontalMovement(direction);
        }    
    }

    private void Jump() 
    {
        if (isGrounded) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.SetTrigger("Jump");
        }
    }

    private void HorizontalMovement(float direction) 
    {
        rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
        anim.SetTrigger("Walk");
        anim.SetFloat("Velocity", Mathf.Abs(rb.velocity.x));
    }
}
