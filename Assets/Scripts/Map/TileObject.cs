using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class TileObject 
{

    [SerializeField] TileStats stats;
    [SerializeField] Vector2Int tileXY;
    [SerializeField] Vector2Int chunkXY;
    [SerializeField] Vector2Int sectorXY;

    public TileObject(Vector2Int sectorXY, Vector2Int chunkXY, Vector2Int tileXY, string type)
    {

        TileXY = tileXY;
        ChunkXY = chunkXY;
        SectorXY = sectorXY;
        stats = (TileStats)Resources.Load("Map/Tiles/" + type);
        if(type != "Plain") SetTileAsset(chunkXY, tileXY);


    }

    private void SetTileAsset(Vector2Int chunkXY, Vector2Int tileXY)
    {
        Transform tilemap = MapState.instance.transform.GetChild(0).GetChild(0);
        Tilemap sector = tilemap.GetComponent<Tilemap>();
        int posX = chunkXY.x * 11 + tileXY.x;
        int posY = chunkXY.y * 11 + tileXY.y;
        sector.SetTile(new Vector3Int(posX, posY, 0), stats.TileAsset);
    }

    public Vector2Int TileXY { get => tileXY; set => tileXY = value; }
    public Vector2Int ChunkXY { get => chunkXY; set => chunkXY = value; }
    public Vector2Int SectorXY { get => sectorXY; set => sectorXY = value; }

}
