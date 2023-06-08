using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Gm.puntaje = PlayerCounter.Instance.counter;
            SceneManager.LoadScene("Nivel 2");
        }
    }
}
