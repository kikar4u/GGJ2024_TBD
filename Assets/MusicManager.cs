using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioClip musicClip;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
