using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;

    public void Respawnear()
    {
        CharacterController cc = GetComponent<CharacterController>();
        if (cc != null) cc.enabled = false;

        transform.position = respawnPoint.position;

        if (cc != null) cc.enabled = true;
    }

    // SOLO PARA PROBAR (luego lo puedes borrar)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawnear();
        }
    }
}
