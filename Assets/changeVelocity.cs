using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class changeVelocity : MonoBehaviour
{
    public VisualEffect effect;
    public Rigidbody playerRb;
    public float minVelocityMagnitude;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.identity;
        if(playerRb.velocity.magnitude > minVelocityMagnitude)
        {
            effect.SetInt("Rate", 16);
            Debug.Log(playerRb.velocity.magnitude);
            effect.SetVector3("Velocity", -playerRb.velocity);
        }
        else
        {
            effect.SetVector3("Velocity", Vector3.zero);
            effect.SetInt("Rate", 0);
        }
    }
}
