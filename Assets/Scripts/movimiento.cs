using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Variables de velocidad
    public float velocidadGiro;
    public float velocidadMovimiento;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent <CharacterController>();
    }

    
    void Update()
    {
        float giro = Input.GetAxis("Horizontal");
        float avance = Input.GetAxis("Vertical");

        // Giramos en el eje Y
        transform.Rotate(0, giro * velocidadGiro * Time.deltaTime, 0);

        // Movimiento en función de hacia donde mira
        Vector3 movimiento = transform.forward * (avance * velocidadMovimiento);

        // Asignamos es movimiento al GameController
        controller.Move(movimiento * Time.deltaTime);
    }
}
