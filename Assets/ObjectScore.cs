using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScore : MonoBehaviour
{
    private GameManager gameManager;
    
    private bool hasTouchFloor;

    [SerializeField] int scoreToAdd = 10;
    // Start is called before the first frame update
    void Start()
    {
        hasTouchFloor = false;
        gameManager = GameManager.Instance;
    }
    private void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "floor" && !hasTouchFloor)
        {
            //Debug.Log("has touched");
            hasTouchFloor = true;
            gameManager.addScore(scoreToAdd);
        }
    }
}
