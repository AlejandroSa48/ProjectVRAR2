using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI Variables")]
    public int counter = 0;
    public int health = 100;
    public int lives = 3;
    
    public int completedLessons = 0;
    public int visitedRooms = 0;

    public bool lessonCompleted = false;
    public bool demoPlaying = false;

    public string currentRoom = "Lobby";
    public string currentTopic = "Tema 1";

    public float headsetHeight = 1.7f;

    public event Action OnCounterChanged;
    public event Action OnHealthChanged;
    public event Action OnLivesChanged;

    private void Awake()
    {
        Instance = this;
        Debug.Log(CalculateScore(5));
        Debug.Log(CalculateLives(1));
        Debug.Log(GetRoomName(1));

        Debug.Log(CalculateScore(10));
        Debug.Log(GetRoomName(2));
        
        AddCounter(1);
        AddHealth(5);
        AddLives(1);

        AddScoreAndHealth(2, 10);
        AddLivesAndCounter(1, 5);
    }

    public void AddCounter(int amount)
    {
        counter += amount;
        OnCounterChanged?.Invoke();
    }

    public void AddHealth(int amount)
    {
        health += amount;
        OnHealthChanged?.Invoke();
    }

    public void AddLives(int amount)
    {
        lives += amount;
        OnLivesChanged?.Invoke();
    }

    public int GetCounter()
    {
        return counter;
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetLives()
    {
        return lives;
    }
    public void AddScoreAndHealth(int scoreAmount, int healthAmount)
    {
        completedLessons += scoreAmount;
        health += healthAmount;
    }

    public void AddLivesAndCounter(int livesAmount, int counterAmount)
    {
        lives += livesAmount;
        counter += counterAmount;
    }

    public void ChangeRoomAndTopic(string room, string topic)
    {
        currentRoom = room;
        currentTopic = topic;
    }
    public int CalculateScore(int lessons)
    {
        return lessons * 10;
    }

    public int CalculateLives(int bonus)
    {
        return lives + bonus;
    }

    public string GetRoomName(int roomNumber)
    {
        return "Room " + roomNumber;
    }
}