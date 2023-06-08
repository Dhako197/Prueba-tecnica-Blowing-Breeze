using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gm : MonoBehaviour
{
    public static float puntaje;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
