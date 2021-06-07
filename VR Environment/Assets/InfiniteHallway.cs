using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteHallway : MonoBehaviour
{
    public Vector3 moveDistance;
    public Transform hallway;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player");
            hallway.position = hallway.position + moveDistance;
        }
        else
        {
            Debug.Log("Other");
        }
    }
}
