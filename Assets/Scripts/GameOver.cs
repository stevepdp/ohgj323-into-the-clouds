using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] Button restartButton;

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
        {
            gameOverPanel.SetActive(true);

            if (restartButton != null)
                restartButton.interactable = true;
        }
    }
}
