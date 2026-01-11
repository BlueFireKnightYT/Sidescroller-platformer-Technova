using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public GameManager gameManager;
    private void Start()
    {
        gameManager.coins = PlayerPrefs.GetInt("coins");
        gameManager.scoreText.text = gameManager.coins.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Frog"))
        {
            gameManager.coins++;
            Debug.Log(gameManager.coins);
            Destroy(this.gameObject);
            PlayerPrefs.SetInt("coins", gameManager.coins);

            gameManager.scoreText.text = gameManager.coins.ToString();
        }
    }
}
