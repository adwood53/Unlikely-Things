using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGen : MonoBehaviour
{
    public bool genOnAwake = false;
    bool hasGenerated = false;
    public float chunkSize = 10;
    public GameObject[] chunks;
    public Vector2Int worldSizeInChunks;
    // Start is called before the first frame update
    void Start()
    {
        if (genOnAwake) Gen();
    }

    public void Gen()
    {
        if (hasGenerated) Delete();
        hasGenerated = true;

        GameObject parent = new GameObject();
        parent.name = "ChunkParent";
        parent.transform.SetParent(transform);

        GameObject chunk;



        Vector3 offset = Vector2.zero;
        for (int x = 0; x < worldSizeInChunks.x; x++)
        {   
            for (int z = 0; z < worldSizeInChunks.y; z++)
            {
                chunk = (GameObject)Instantiate(chunks[Random.Range(0, chunks.Length - 1)], Vector3.zero + offset, Quaternion.identity);
                chunk.transform.SetParent(parent.transform);
                chunk.name = "ChunkChild" + x + z;
                offset.z += chunkSize;
            }
            offset.x += chunkSize;
            offset.z = 0;
        }
        parent.transform.position = new Vector3(0 - ((chunkSize * worldSizeInChunks.x) / 2), 0, 0 - ((chunkSize * worldSizeInChunks.y) / 2));
    }

    public void Delete()
    {
        hasGenerated = false;
        DestroyImmediate(transform.Find("ChunkParent").gameObject);
    }


}
