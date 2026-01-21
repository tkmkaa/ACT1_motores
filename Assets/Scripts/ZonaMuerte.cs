using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Jugador murio");
            CharacterController cc = other.GetComponent<CharacterController>();

            if (cc != null) {
                Vector3 resetVelocity = Vector3.zero;
                cc.enabled = false;
                other.transform.position = respawnPoint.position;
                cc.enabled = true;
            }
            
           
        }
    }
}
