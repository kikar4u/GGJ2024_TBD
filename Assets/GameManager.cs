using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        Debug.Log(score);
    }
    
    public void StopGame()
    {
        Time.timeScale = 0;

    }
    public int GetScore()
    {
        return score;
    }
    public void addScore(int scoreToAdd) { 
        score += scoreToAdd;
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
