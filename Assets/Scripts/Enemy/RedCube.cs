using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerCounter.Instance.Sound(audioClip);
            PlayerCounter.Instance.RemoveCounter();
            PlayerMovement.Instance.KnockBack(transform);
        }
    }
}
