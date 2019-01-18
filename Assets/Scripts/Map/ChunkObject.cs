using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkObject 
{
    [SerializeField] ChunkStats stats;
    [SerializeField] List<TileObject> tiles = new List<TileObject>();
    [SerializeField] Vector2Int chunkXY;
    [SerializeField] Vector2Int sectorXY;

    public ChunkObject(Vector2Int sectorXY, Vector2Int chunkXY)
    {
        ChunkXY = chunkXY;
        SectorXY = sectorXY;
        GenerateTiles(sectorXY, chunkXY);
    }

    public List<TileObject> Tiles { get => tiles; set => tiles = value; }
    public Vector2Int ChunkXY { get => chunkXY; set => chunkXY = value; }
    public Vector2Int SectorXY { get => sectorXY; set => sectorXY = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateTiles(Vector2Int sectorXY, Vector2Int chunkXY)
    {

        GameObject tilePrefab = Resources.Load("Map/Tiles/Tile") as GameObject;
        string[] types = { "Plain", "Sand" };
        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11; j++)
            {

                string type = types[Random.Range(0,2)];
                Tiles.Add(new TileObject(sectorXY, chunkXY, new Vector2Int(i, j), type));
            }
        }



    }
}
