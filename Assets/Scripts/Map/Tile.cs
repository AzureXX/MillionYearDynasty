using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] TileStats stats;
    [SerializeField] Vector2 tileXY;
    [SerializeField] Vector2 chunkXY;
    [SerializeField] Vector2 sectorXY;

    
    public Tile(string type, Vector2 tileXY, Vector2 chunkXY, Vector2 sectorXY)
    {
        this.tileXY = tileXY;
        this.chunkXY = chunkXY;
        this.sectorXY = sectorXY;
        stats = (TileStats)Resources.Load("Map/Tiles/" + type);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
