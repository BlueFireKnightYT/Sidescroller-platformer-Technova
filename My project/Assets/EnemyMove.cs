using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Rigidbody2D enemyRb;

    public float posLeft;
    public float posRight;


    float nextPos;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        nextPos = posRight;
    }

    // Update is called once per frame
    void Update()
    {
        if   (Mathf.Abs(transform.position.x - nextPos) < 0.05f)
            {
            if(nextPos == posRight)
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
        
    }
}
