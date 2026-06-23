using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    private void Start()
    {
        UpdateHealth();

        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnHealthChanged += UpdateHealth;
        }
    }

    private void OnDestroy()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnHealthChanged -= UpdateHealth;
        }
    }

    private void UpdateHealth()
    {
        healthText.text = "Health: " + GameManager.Instance.health;
    }
}