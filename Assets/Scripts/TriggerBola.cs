using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBola : MonoBehaviour
{
    public GameObject bola;
    public Transform[] spawnPoints;
    bool activado = false;

    void OnTriggerEnter(Collider other)
    {
        if (activado) return;

        if (other.CompareTag("Player"))
        {
            foreach (Transform punto in spawnPoints)
            {
                Instantiate(bola, punto.position, punto.rotation);
            }

            activado = true;
        }
    }
}
