using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    public float altura= 2f;
    public float velocidad= 1.5f;
    private Vector3 inicio; // posicion inicial

    void Start()
    {
        inicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = inicio + Vector3.up * Mathf.PingPong(Time.time * velocidad , altura);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player")){
            col.gameObject.GetComponent<Respawn>()?.Respawnear();
        }

    }
}
