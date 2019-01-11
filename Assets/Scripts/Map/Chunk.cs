using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk
{
    [SerializeField] ChunkStats stats;
    [SerializeField] List<Tile> tiles = new List<Tile>();
    [SerializeField] Vector2 chunkXY;
    [SerializeField] Vector2 sectorXY;

    public Chunk(string type, Vector2 chunkXY, Vector2 sectorXY)
    {
        stats = (ChunkStats)Resources.Load("Map/Chucks/" + type);
        this.chunkXY = chunkXY;
        this.sectorXY = sectorXY;
        for(int i=-4; i < 5; i++)
        {
            for (int j = -4; j < 5; j++)
            {
                tiles.Add(new Tile("Plain", new Vector2(i,j), chunkXY, sectorXY));
            }
        }
    }

    public List<Tile> Tiles { get => tiles; set => tiles = value; }
    public Vector2 ChunkXY { get => chunkXY; set => chunkXY = value; }
    public Vector2 SectorXY { get => sectorXY; set => sectorXY = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
