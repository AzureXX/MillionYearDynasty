using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapState : MonoBehaviour
{
    #region Singleton
    public static MapState instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else if (instance != this)
            Destroy(gameObject);

    }
    #endregion

    [SerializeField] List<SectorObject> sectors = new List<SectorObject>();

    public List<SectorObject> Sectors { get => sectors; set => sectors = value; }

    // Start is called before the first frame update
    void Start()
    {
        GenerateInitialSector();
    }

    public void GenerateInitialSector()
    {
        Sectors.Add(new SectorObject(new Vector2Int(0, 0)));
    }

    public void GetAllChunks()
    {
        foreach(SectorObject sector in sectors)
        {
            foreach(ChunkObject chunk in sector.Chunks)
            {
                foreach(TileObject tile in chunk.Tiles)
                {
                    Debug.Log(tile.SectorXY + " : " + tile.ChunkXY + ":" + tile.TileXY);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
