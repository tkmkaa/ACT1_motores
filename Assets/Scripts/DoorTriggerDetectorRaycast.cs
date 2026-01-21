using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerDetectorRaycast : MonoBehaviour
{
    [SerializeField] Canvas detectedCanvas;
    [SerializeField] Camera playerCamera;
    [SerializeField] LayerMask layerMask;
    float rayDistance = 2.5f;
    LeverOpener currentLever;    

    void Update()
    {
        bool leverDetected = false;
        currentLever = null;

        if (Physics.SphereCast(playerCamera.transform.position, 0.2f, playerCamera.transform.forward, out RaycastHit hit, rayDistance, layerMask))
        {
            if (hit.collider.CompareTag("Lever"))
            {
                Debug.Log("Detecto una palanca.");
                leverDetected = true;
                currentLever = hit.collider.GetComponent<LeverOpener>();
            }
        }
        detectedCanvas.gameObject.SetActive(leverDetected);
        
        if (leverDetected && Input.GetKeyDown(KeyCode.E))
        {
            currentLever?.Activate_Lever();
        }

            Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward * rayDistance, Color.red);

        }


    }



