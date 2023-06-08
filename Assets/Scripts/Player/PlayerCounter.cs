using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class PlayerCounter : MonoBehaviour
{
    public static PlayerCounter Instance { get; private set; }
    public float counter=0;
    private AudioSource audioClip;
    [SerializeField] private TextMeshProUGUI counterText;

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

       
    }

    // Start is called before the first frame update
    void Start()
    {
        audioClip= GetComponent<AudioSource>();
        
    }
    private void Update()
    {
        counterText.text = "Puntos= " + counter;
    }

    public void AddCounter()
    {
        counter +=2;
        counterText.text = "Puntos= " + counter;
    }

    public void RemoveCounter()
    {
        counter--;
        counterText.text = "Puntos= " + counter;
    }
    public void Sound(AudioClip clip)
    {
        audioClip.PlayOneShot(clip);
    }
    
    public void KnockBack()
    {

    }
}
