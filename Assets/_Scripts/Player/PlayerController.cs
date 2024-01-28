using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private bool isJumping = false;
    [SerializeField] private LayerMask LayerMask;
    public GameObject test;
    [Range(0f, 10f)]
    [SerializeField] float jumpPower = 2;
    [SerializeField] int scoreToAdd = 20;
    GameManager gameManager;
    PlayerSoundController playerSoundController;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        playerSoundController = GetComponent<PlayerSoundController>();
        playerRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Check if the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in screen coordinates
            Vector3 mousePosition = Input.mousePosition;

            // Create a ray from the camera through the mouse position
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            // Declare a RaycastHit variable to store information about the hit
            RaycastHit hit;

            // Check if the ray hits something in the scene
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(Camera.main.ScreenPointToRay(mousePosition).origin, hit.point, Color.yellow, Mathf.Infinity);
                if (hit.collider.gameObject.name == "Player")
                {
                }
                move(hit.point);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerSoundController.JumpSound();
            playerRb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            
        }
    }
    public void move(Vector3 hitPosition)
    {
        Vector3 jumpDirection = hitPosition - transform.position;
        jumpDirection.Normalize();
        // Apply a force to make the object jump
        playerRb.velocity = jumpDirection * jumpPower;
        // Limit the maximum speed
        playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, 5);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "launchable")
        {
            gameManager.addScore(scoreToAdd);
        }
    }
}
