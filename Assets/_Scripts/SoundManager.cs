using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    /*    [SerializeField]
        StringAudioClipDictionary soundLibrary;
        public IDictionary<string, AudioClip> soundLibraryDictionary
        {
            get { return soundLibrary; }
            set { soundLibrary.CopyFrom(value); }
        }*/
    public List<AudioClip> toaster;
    public List<AudioClip> bouteille;
    public List<AudioClip> carton;
    public List<AudioClip> couronne;
    public List<AudioClip> ecran;
    public List<AudioClip> machineaCafe;
    public List<AudioClip> poisson;
    public List<AudioClip> burger;
    public List<AudioClip> sushi;
    public List<AudioClip> chair;
    public List<AudioClip> mixeur;
    public List<AudioClip> mo;
    public List<AudioClip> bumper;
    public static SoundManager Instance { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {

        // If there is an instance, and it's not me, delete myself.
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playerCollisionSound(typeOfObject soundType, AudioSource source)
    {
        source.pitch = Random.Range(0.0f, 3.0f);
        switch (soundType)
        {
            case typeOfObject.toaster:
                source.clip = toaster[Random.Range(0, toaster.Count)];
                break;
            case typeOfObject.poisson:
                source.clip = poisson[Random.Range(0, poisson.Count)];
                break;
            case typeOfObject.bouteille:
                Debug.Log("BOUTEILLE");
                source.clip = bouteille[Random.Range(0, bouteille.Count)];
                break;
            case typeOfObject.carton:
                source.clip = carton[Random.Range(0, carton.Count)];
                break;
            case typeOfObject.couronne:
                source.clip = couronne[Random.Range(0, couronne.Count)];
                break;
            case typeOfObject.ecran:
                source.clip = ecran[Random.Range(0, ecran.Count)];
                break;
            case typeOfObject.machineaCafe:
                source.clip = machineaCafe[Random.Range(0, machineaCafe.Count)];
                break;
            case typeOfObject.burger:
                source.clip = burger[Random.Range(0, burger.Count)];
                break;
            case typeOfObject.sushi:
                source.clip = sushi[Random.Range(0, sushi.Count)];
                break;
            case typeOfObject.chair:
                source.clip = chair[Random.Range(0, chair.Count)];
                break;
            case typeOfObject.mo:
                source.clip = mo[Random.Range(0, mo.Count)];
                break;
            case typeOfObject.mixeur:
                source.clip = mixeur[Random.Range(0, mixeur.Count)];
                break;
            case typeOfObject.bumper:
                source.clip = bumper[Random.Range(0, bumper.Count)];
                break;
        }
        source.Play();
    }
}
