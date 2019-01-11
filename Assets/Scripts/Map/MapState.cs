using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    [SerializeField] List<Sector> sectors = new List<Sector>();

    // Start is called before the first frame update
    void Start()
    {
        sectors.Add(new Sector("Plain", new Vector2(0, 0)));
        int chunkIndex = FindIndexFromXY(new Vector2(-2, 0));
        int tileIndex = FindIndexFromXY(new Vector2(-3, 0));
        Debug.Log(sectors[0].Chunks[chunkIndex].ChunkXY);
        Debug.Log(sectors[0].Chunks[chunkIndex].Tiles[tileIndex].TileXY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int FindIndexFromXY(Vector2 xy)
    {
        return (int)(xy.x * 9 + (int)xy.y + 40);
    }

}
