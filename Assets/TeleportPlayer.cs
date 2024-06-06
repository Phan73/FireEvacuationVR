using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform startTeleport; // Reference to the Start Teleport position

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Teleport the player to the start position
            other.transform.position = startTeleport.position;
        }
    }
}
