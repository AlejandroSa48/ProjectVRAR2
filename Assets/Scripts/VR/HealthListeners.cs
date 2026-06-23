using UnityEngine;

public class HealthListeners : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.OnHealthChanged += ListenerOne;
        GameManager.Instance.OnHealthChanged += ListenerTwo;
        GameManager.Instance.OnHealthChanged += ListenerThree;
    }

    private void ListenerOne()
    {
        Debug.Log("Health Listener 1");
    }

    private void ListenerTwo()
    {
        Debug.Log("Health Listener 2");
    }

    private void ListenerThree()
    {
        Debug.Log("Health Listener 3");
    }
}