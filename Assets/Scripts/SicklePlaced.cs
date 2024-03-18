using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SicklePlaced : MonoBehaviour
{
    public bool isOccupied = false;

    // This method is called when another object enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the right object
        if (other.CompareTag("Sickle"))
        {
            isOccupied = true;
            UnityEngine.Debug.Log("Sickle_to_move dropped on the Socket_staff!");
        }
    }

    // This method is called when another object exits the trigger collider
    private void OnTriggerExit(Collider other)
    {
        // Check if the object exiting the trigger is the right object
        if (other.CompareTag("Sickle") && !isOccupied)
        {
            UnityEngine.Debug.Log("Sickle_to_move removed from the Socket_staff!");
        }
    }
}
