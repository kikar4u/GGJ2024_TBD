using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundController : MonoBehaviour
{

    public List<AudioClip> clipList;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void JumpSound()
    {
        int randomNumber = Random.Range(0, clipList.Count);
        float randomPitch = Random.Range(0, 3);
        audioSource.clip = clipList[randomNumber];
        audioSource.pitch = randomPitch; 
        audioSource.Play();
    }
}
