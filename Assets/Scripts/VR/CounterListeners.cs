using UnityEngine;

public class CounterListeners : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.OnCounterChanged += ListenerOne;
        GameManager.Instance.OnCounterChanged += ListenerTwo;
        GameManager.Instance.OnCounterChanged += ListenerThree;
    }

    void ListenerOne()
    {
        Debug.Log("Counter Listener 1");
    }

    void ListenerTwo()
    {
        Debug.Log("Counter Listener 2");
    }

    void ListenerThree()
    {
        Debug.Log("Counter Listener 3");
    }
}