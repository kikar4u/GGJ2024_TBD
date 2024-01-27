using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int score;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.
        score = 0;
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    private void Update()
    {
        Debug.Log(score);
    }
    public int GetScore()
    {
        return score;
    }
    public void addScore(int scoreToAdd) { 
        score += scoreToAdd;
    }
}
