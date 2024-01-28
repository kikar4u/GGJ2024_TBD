using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] int rejectionForce = 2;
    [SerializeField] int scoreToAdd = 5;
    [SerializeField] int numberOfBumps = 2;
    Animator animator;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision other)
    {
        animator.SetTrigger("bump");
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        // Calculate the direction vector from this object to the target object
        Vector3 direction = transform.position - other.gameObject.transform.position;

        // Normalize the direction vector to get a unit vector
        direction.Normalize();

        // Apply rejection force in the opposite direction
        rb.AddForce(direction * rejectionForce, ForceMode.Impulse);
        if (other.gameObject.tag == "launchable")
        {

            if(numberOfBumps > 0) gameManager.addScore(scoreToAdd);

            if (other.gameObject.name == "Player" && numberOfBumps > 0)
            {
                numberOfBumps--;
            }
        }

    }
}
