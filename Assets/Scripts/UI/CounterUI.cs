using TMPro;
using UnityEngine;

public class CounterUI : MonoBehaviour
{
    public TextMeshProUGUI counterText;

    private void Start()
    {
        UpdateCounter();

        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnCounterChanged += UpdateCounter;
        }
    }

    private void OnDestroy()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnCounterChanged -= UpdateCounter;
        }
    }

    private void UpdateCounter()
    {
        counterText.text = "Counter: " + GameManager.Instance.counter;
    }
}