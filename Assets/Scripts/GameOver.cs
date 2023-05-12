using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;

    void OnEnable()
    {
        Player.OnGameOver += OnGameOver;
    }

    void OnDisable()
    {
        Player.OnGameOver -= OnGameOver;
    }

    void OnGameOver()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }
}
