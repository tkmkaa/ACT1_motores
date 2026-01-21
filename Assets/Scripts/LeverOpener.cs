using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverOpener : MonoBehaviour
{
    public OpenDoor[] doors;
    
    public void Activate_Lever()
    {
        foreach (OpenDoor door in doors){

            door.AbrirPuerta();
        }
    }
    
    
}
