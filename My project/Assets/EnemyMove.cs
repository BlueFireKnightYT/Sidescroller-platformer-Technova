using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Rigidbody2D enemyRb;

    public float posLeft;
    public float posRight;

    float nextPos;

    [Header("Jump")]
    public float jumpForce = 6f;
    public float jumpEverySeconds = 1.5f;
    private float jumpTimer;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        nextPos = posRight;
        jumpTimer = jumpEverySeconds;
    }

    void Update()
    {
        if (Mathf.Abs(transform.position.x - nextPos) < 0.05f)
        {
            if (nextPos == posRight)
            {
                nextPos = posLeft;
            }
            else
            {
                nextPos = posRight;
            }
        }

        if (nextPos == posRight)
        {
            enemyRb.linearVelocityX = 1;
        }
        else
        {
            enemyRb.linearVelocityX = -1;
        }

        // ---- jumping every X seconds ----
        jumpTimer -= Time.deltaTime;
        if (jumpTimer <= 0f)
        {
            enemyRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpTimer = jumpEverySeconds;
        }
    }
}
