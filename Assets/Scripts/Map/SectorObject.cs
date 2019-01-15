using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectorObject
{
    [SerializeField] SectorStats stats;
    [SerializeField] List<ChunkObject> chunks = new List<ChunkObject>();
    [SerializeField] Vector2Int sectorXY;

    public SectorObject(Vector2Int sectorXY)
    {
        SectorXY = sectorXY;
    }

    public List<ChunkObject> Chunks { get => chunks; set => chunks = value; }
    public Vector2Int SectorXY { get => sectorXY; set => sectorXY = value; }


    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateChunks(Vector2Int sectorXY)
    {
        GameObject chunkPrefab = Resources.Load("Map/Chunks/Chunk") as GameObject;

        for(int i = 0; i < 11; i++)
        {
            for(int j = 0; j< 11; j++)
            {

            }
        }
      

    }
}
