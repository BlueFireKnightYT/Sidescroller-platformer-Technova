using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;

    public TMP_Text livesText;   // drag TMP Text here

    public float invincibleTime = 1f;
    private bool invincible = false;

    void Start()
    {
        UpdateLivesText();
    }

    public void TakeDamage(int amount)
    {
        if (invincible) return;

        lives -= amount;
        UpdateLivesText();

        if (lives <= 0)
        {
            Die();
        }
        else
        {
            StartCoroutine(InvincibleCooldown());
        }
    }

    private System.Collections.IEnumerator InvincibleCooldown()
    {
        invincible = true;
        yield return new WaitForSeconds(invincibleTime);
        invincible = false;
    }

    private void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = "" + lives;
        }
    }

    private void Die()
    {
        Debug.Log("Player died!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
