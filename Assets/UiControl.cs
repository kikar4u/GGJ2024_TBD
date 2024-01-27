using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiControl : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        score.text = gameManager.GetScore().ToString();
    }
}
