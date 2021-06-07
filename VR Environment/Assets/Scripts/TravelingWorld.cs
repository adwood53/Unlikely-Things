using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelingWorld : MonoBehaviour
{

    public bool isTravelling = true; //Is the world travelling or not
    public float travelDistance = 10f; //Distance the traveller has to move for the world to follow
    public Transform traveller; //The global transform for the object to track
    Transform world; //The global transform for the travelling world
    float xoffset = 0;
    float zoffset = 0;

    private void Start()
    {
        world = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTravelling)
        {
            Vector3 worldpos = world.position;
            if (traveller.position.x > travelDistance + xoffset)
            {
                world.position = new Vector3(worldpos.x + travelDistance, worldpos.y, worldpos.z);
                xoffset += travelDistance;
            }
            if (traveller.position.x < -travelDistance + xoffset)
            {
                world.position = new Vector3(worldpos.x - travelDistance, worldpos.y, worldpos.z);
                xoffset -= travelDistance;
            }
            if (traveller.position.z > travelDistance + zoffset)
            {
                world.position = new Vector3(worldpos.x, worldpos.y, worldpos.z + travelDistance);
                zoffset += travelDistance;
            }
            if (traveller.position.z < -travelDistance + zoffset)
            {
                world.position = new Vector3(worldpos.x, worldpos.y, worldpos.z - travelDistance);
                zoffset -= travelDistance;
            }

        }
    }
}
