using UnityEngine;

public class LivesCube : MonoBehaviour
{
    public void AddLife()
    {
        GameManager.Instance.AddLives(1);
    }
}