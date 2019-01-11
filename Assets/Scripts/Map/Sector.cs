using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector
{
    [SerializeField] SectorStats stats;
    [SerializeField] List<Chunk> chunks = new List<Chunk>();
    [SerializeField] Vector2 sectorXY;


    public Sector(string type, Vector2 sectorXY)
    {
        stats = (SectorStats)Resources.Load("Map/Sectors/" + type);
        this.sectorXY = sectorXY;
        for (int i = -4; i < 5; i++)
        {
            for (int j = -4; j < 5; j++)
            {
                chunks.Add(new Chunk("Plain", new Vector2(i, j),sectorXY));
            }
        }
    }

    public List<Chunk> Chunks { get => chunks; set => chunks = value; }
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
