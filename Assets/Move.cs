using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float moveSpeed;
    [SerializeField] private int maxJumps;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    public int jumpCount;

    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
       
        //Flips player sprite
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        // If space is pressed
        if (Input.GetKeyDown(KeyCode.Space)) { 

            // 1.0 Check total amounts of jump ex. (if jumpCount < maxJumps then let player jump)
            if (jumpCount < maxJumps) {
                Jump();
                
            }
        }

        // Check if the player is grounded then reset jumpCount to 0
        if (isGrounded())
        {
            jumpCount = 0;
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, moveSpeed);
        jumpCount += 1;
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }
}
