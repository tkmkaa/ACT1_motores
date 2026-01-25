using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaKill : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Respawn r = collision.collider.GetComponent<Respawn>();
            if (r != null)
                r.Respawnear();
            Destroy(gameObject);
        }
        
    }
}
