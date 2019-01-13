using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkScript : MonoBehaviour 
{
    [SerializeField] ChunkStats stats;
    [SerializeField] List<TileScript> tiles = new List<TileScript>();
    [SerializeField] Vector2Int chunkXY;
    [SerializeField] Vector2Int sectorXY;

   

    public List<TileScript> Tiles { get => tiles; set => tiles = value; }
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

        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                int tilePosX = i + 11 * chunkXY.x + 121 * sectorXY.x;
                int tilePosY = j + 11 * chunkXY.y + 121 * sectorXY.y;
                GameObject tile = Instantiate(tilePrefab, new Vector3(tilePosX, tilePosY, 0), Quaternion.identity);
                tile.transform.parent = transform;
                var tileStats = tile.GetComponent<TileScript>();
                tileStats.SectorXY = sectorXY;
                tileStats.ChunkXY = chunkXY;
                tileStats.TileXY = new Vector2Int(i, j);
            }
        }



    }
}
