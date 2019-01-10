using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] TileStats stats;
    [SerializeField] Vector2 tileXY;
    [SerializeField] Vector2 chunkXY;
    [SerializeField] Vector2 sectorXY;

    public Tile(Vector2 tileXY)
    {
        this.tileXY = tileXY;
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
