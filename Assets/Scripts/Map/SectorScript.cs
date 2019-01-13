using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectorScript : MonoBehaviour
{
    [SerializeField] SectorStats stats;
    [SerializeField] List<ChunkScript> chunks = new List<ChunkScript>();
    [SerializeField] Vector2Int sectorXY;




    public List<ChunkScript> Chunks { get => chunks; set => chunks = value; }
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
                GameObject chunk = Instantiate(chunkPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                chunk.transform.parent = transform;
                var chunkStats = chunk.GetComponent<ChunkScript>();
                chunkStats.SectorXY = sectorXY;
                chunkStats.ChunkXY = new Vector2Int(i, j);
                chunkStats.GenerateTiles(chunkStats.SectorXY, chunkStats.ChunkXY);
            }
        }
      

    }
}
