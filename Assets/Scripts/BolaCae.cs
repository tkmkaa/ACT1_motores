using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaCae : MonoBehaviour
{
    public float fuerzaRebote = 8f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay(Collision collision)
    {
        // Si toca al jugador → muere y la bola desaparece
        if (collision.collider.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Respawn>()?.Respawnear();

            BolaCae[] todasBolas = FindObjectsOfType<BolaCae>();
            foreach (BolaCae bola in todasBolas)
            {
                Destroy(bola.gameObject);
            }

            return;
        }
        // Rebote constante (misma altura siempre)
        rb.velocity = new Vector3(rb.velocity.x, fuerzaRebote, rb.velocity.z);
    }
}