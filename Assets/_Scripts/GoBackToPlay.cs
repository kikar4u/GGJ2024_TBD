using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GoBackToPlay : MonoBehaviour
{
    [SerializeField] Transform respawnPosition;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            other.gameObject.transform.position = respawnPosition.position;
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
