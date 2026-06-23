using UnityEngine;

public class HealthCube : MonoBehaviour
{
    public void AddHealth()
    {
        GameManager.Instance.AddHealth(10);
    }
}