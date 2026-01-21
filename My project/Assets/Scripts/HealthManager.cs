using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TMP_Text livesText;

    void Update()
    {
        if (playerHealth != null && livesText != null)
        {
            livesText.text = playerHealth.Lives.ToString();
        }
    }
}
