using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    bool isOpen = false;

    public void AbrirPuerta()
    {
        if (isOpen) return;
        isOpen = true;
        Debug.Log("Puerta abierta.");

        transform.parent.Rotate(0, 90f, 0);
    }
}
