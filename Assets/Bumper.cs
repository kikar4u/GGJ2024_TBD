using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] int rejectionForce = 2;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "launchable")
        {
            animator.SetTrigger("bump");
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            // Calculate the direction vector from this object to the target object
            Vector3 direction = transform.position - other.gameObject.transform.position;

            // Normalize the direction vector to get a unit vector
            direction.Normalize();

            // Apply rejection force in the opposite direction
            rb.AddForce(direction * rejectionForce, ForceMode.Impulse);
        }
    }
}
