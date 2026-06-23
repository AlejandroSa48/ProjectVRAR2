using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    private void Start()
    {
        UpdateLives();

        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnLivesChanged += UpdateLives;
        }
    }

    private void OnDestroy()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnLivesChanged -= UpdateLives;
        }
    }

    private void UpdateLives()
    {
        livesText.text = "Lives: " + GameManager.Instance.lives;
    }
}