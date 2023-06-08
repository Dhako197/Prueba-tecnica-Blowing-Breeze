using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothMovement = 0.5f;
    private Vector3 inicialPos;

    private void Start()
    {
        inicialPos = transform.position;
    }

    private void LateUpdate()
    {
        Vector3 posicionActual = transform.position;
        posicionActual.y = inicialPos.y;
        Vector3 posicionObjetivo = player.position;
        posicionObjetivo.z = inicialPos.z;
        Vector3 posicionInterpolada = Vector3.Lerp(posicionActual, posicionObjetivo, smoothMovement * Time.deltaTime);
        transform.position = posicionInterpolada;
    }
}
