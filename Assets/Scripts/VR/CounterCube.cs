using UnityEngine;

public class CounterCube : MonoBehaviour
{
    public void AddPoint()
    {
        GameManager.Instance.AddCounter(1);
    }
}