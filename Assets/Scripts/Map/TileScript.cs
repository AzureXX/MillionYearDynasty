using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{

    [SerializeField] TileStats stats;
    [SerializeField] Vector2Int tileXY;
    [SerializeField] Vector2Int chunkXY;
    [SerializeField] Vector2Int sectorXY;


    public Vector2Int TileXY { get => tileXY; set => tileXY = value; }
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
    private void OnMouseDown()
    {
        Debug.Log(transform.position);
    }
}
