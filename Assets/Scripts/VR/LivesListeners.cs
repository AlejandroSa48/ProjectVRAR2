using UnityEngine;

public class LivesListeners : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.OnLivesChanged += ListenerOne;
        GameManager.Instance.OnLivesChanged += ListenerTwo;
        GameManager.Instance.OnLivesChanged += ListenerThree;
    }

    private void ListenerOne()
    {
        Debug.Log("Lives Listener 1");
    }

    private void ListenerTwo()
    {
        Debug.Log("Lives Listener 2");
    }

    private void ListenerThree()
    {
        Debug.Log("Lives Listener 3");
    }
}