using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] List<Transform> pivot = new List<Transform>();
    List<GameObject> instatieObstacles = new List<GameObject>();

    public void Start()
    {
        ObstaclesGenerate();
    }

    public void ObstaclesGenerate()
    {
        ObstaclesDestroy();

        for (int i = 0; i < pivot.Count; i++)
        {
            int randomNum = Random.Range(1,6);
            GameObject obstacle = (GameObject)Instantiate(Resources.Load("Prefab/Obtacle" + randomNum), pivot[i]);
            obstacle.transform.localPosition = Vector3.zero;
            instatieObstacles.Add(obstacle);   
        }
    }

    public void ObstaclesDestroy()
    {
        for (int i = 0; i < instatieObstacles.Count; i++)
        {
            Destroy(instatieObstacles[i]);
        }

        instatieObstacles.Clear();
    }
}
