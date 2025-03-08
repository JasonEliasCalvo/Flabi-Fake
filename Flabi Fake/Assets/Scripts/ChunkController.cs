using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkController : MonoBehaviour
{
    [SerializeField] List<Chunk> chunks = new List<Chunk>();
    [SerializeField] float speed;
    [SerializeField] Transform Lastchunk;

    void Start()
    {

    }

    void Update()
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            chunks[i].transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (chunks[i].transform.position.x <= -7)
            {
                chunks[i].transform.position = Lastchunk.position + Vector3.right * 7;
                Lastchunk = chunks[i].transform;
                chunks[i].ObstaclesGenerate();
            }
        }
        
    }
}
