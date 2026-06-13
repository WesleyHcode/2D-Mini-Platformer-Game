using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    public float jumpForce = 12f;

    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip hitSound;

    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        rb.linearVelocity =
            new Vector2(move * speed,
                        rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space)
            && isGrounded)
        {
            rb.linearVelocity =
                new Vector2(rb.linearVelocity.x,
                            jumpForce);

            isGrounded = false;

            if(audioSource != null &&
               jumpSound != null)
            {
                audioSource.PlayOneShot(jumpSound);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }

        if(audioSource != null &&
           hitSound != null)
        {
            audioSource.PlayOneShot(hitSound);
        }
    }
}

