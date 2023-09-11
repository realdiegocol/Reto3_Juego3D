using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerTopDown : MonoBehaviour
{
    public Transform player;
    public float heightAbovePlayer = 20f; // Adjust this value as needed.

    void Update()
    {
        Vector3 newPos = player.position;
        newPos.y += heightAbovePlayer;
        transform.position = newPos;
    }
}
