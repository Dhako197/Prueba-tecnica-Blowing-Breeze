using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    [SerializeField] private GameObject finalMenu;

    private void Start()
    {
        PlayerCounter.Instance.counter = Gm.puntaje;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0f;
           finalMenu.SetActive(true);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel 1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
