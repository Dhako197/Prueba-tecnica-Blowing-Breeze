using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUp : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerCounter.Instance.Sound(audioClip);
            PlayerCounter.Instance.AddCounter();       
            gameObject.SetActive(false);
        }
    }
}
