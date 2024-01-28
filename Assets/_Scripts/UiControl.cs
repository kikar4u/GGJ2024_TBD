using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiControl : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    public static UiControl Instance { get; private set; }

    private GameManager gameManager;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject pauseMenu;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        gameManager = GameManager.Instance;
        score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        score.text = gameManager.GetScore().ToString();
    }
    public void ShowMenu()
    {
        menu.SetActive(true);
    }
    public void ShowPauseMenu()
    {
        if (pauseMenu.active)
        {
            pauseMenu.SetActive(false);
        }
        else
        {
            pauseMenu.SetActive(true);
        }
    }
}
