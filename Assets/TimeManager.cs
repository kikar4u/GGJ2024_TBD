using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float countdownDuration = 10f; 
    private float currentTime;

    public TMP_Text countdownText;
    GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.Instance;
        currentTime = countdownDuration;
    }

    void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            UpdateCountdownText();
        }
        else
        {
            gameManager.StopGame();
            UiControl.Instance.ShowMenu();
            Debug.Log("Countdown finished!");
        }
    }

    void UpdateCountdownText()
    {
        countdownText.text = Mathf.CeilToInt(currentTime).ToString();
    }
}
