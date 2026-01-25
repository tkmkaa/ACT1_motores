using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampaPared : MonoBehaviour
{
    public Transform paredIzq;
    public Transform paredDer;

    public Vector3 offsetCerrado;   // cuánto se mueven al cerrarse
    public float velocidad = 2f;
    public float tiempoEntreCambios = 2f;

    Vector3 izqAbierta;
    Vector3 derAbierta;
    Vector3 izqCerrada;
    Vector3 derCerrada;

    bool cerrada = false;
    float timer;

    void Start()
    {
        izqAbierta = paredIzq.position;
        derAbierta = paredDer.position;

        izqCerrada = izqAbierta + offsetCerrado;
        derCerrada = derAbierta - offsetCerrado;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= tiempoEntreCambios)
        {
            cerrada = !cerrada;
            timer = 0f;
        }

        if (cerrada)
        {
            paredIzq.position = Vector3.MoveTowards(
                paredIzq.position, izqCerrada, velocidad * Time.deltaTime);

            paredDer.position = Vector3.MoveTowards(
                paredDer.position, derCerrada, velocidad * Time.deltaTime);
        }
        else
        {
            paredIzq.position = Vector3.MoveTowards(
                paredIzq.position, izqAbierta, velocidad * Time.deltaTime);

            paredDer.position = Vector3.MoveTowards(
                paredDer.position, derAbierta, velocidad * Time.deltaTime);
        }
    }
}
