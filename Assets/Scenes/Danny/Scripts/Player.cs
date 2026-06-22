using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float horizontalSpeed = 3f;
    Rigidbody2D rb;
    BoxCollider2D boxCollider;
    private bool facingRight = true;
    [SerializeField] private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");

        
        transform.Translate(transform.right * horizontalSpeed * horizontal * Time.deltaTime);
        FlipCharacter(horizontal);

        if (horizontal != 0)
        {
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
        
    }


    private void FlipCharacter(float horizontal)
{
    if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
}


