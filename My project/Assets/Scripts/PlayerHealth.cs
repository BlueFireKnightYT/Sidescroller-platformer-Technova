using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;

    public float invincibleTime = 1f;
    private bool invincible = false;
    private bool dead = false;

    public int Lives => lives;

    public void TakeDamage(int amount)
    {
        if (invincible || dead) return;

        lives -= amount;
        if (lives <= 0)
        {
            lives = 0;
            Die();
            return;
        }

        invincible = true;
        Invoke(nameof(EndInvincible), invincibleTime);
    }

    private void EndInvincible()
    {
        invincible = false;
    }

    private void Die()
    {
        dead = true;
        Debug.Log("Je bent dood dusss herlaad scene..");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
