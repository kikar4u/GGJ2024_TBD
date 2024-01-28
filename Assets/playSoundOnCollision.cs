using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundOnCollision : MonoBehaviour
{
    SoundManager soundManager;
    public typeOfObject soundType = 0;
    private AudioSource audioSource;
    private void Start()
    {
        soundManager = SoundManager.Instance; 
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "floor" || other.gameObject.tag == "launchable")
        {
            soundManager.playerCollisionSound(soundType, audioSource);
        }
    }
}
public enum typeOfObject
{
    bouteille = 0,
    toaster = 1,
    carton = 2,
    couronne = 3,
    ecran = 4,
    machineaCafe = 5,
    poisson = 6,
    burger = 7,
    sushi = 8,
    chair = 9,
}
