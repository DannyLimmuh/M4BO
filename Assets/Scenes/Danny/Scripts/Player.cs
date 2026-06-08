using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float horizontalSpeed = 3f;
    Rigidbody2D rb;
    BoxCollider2D boxCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");


        
        transform.Translate(transform.right * horizontalSpeed * horizontal * Time.deltaTime);

        
    }
}
