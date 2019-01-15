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
    
    // Start is called before the first frame update
    void Start()
    {
        Tilemap tilemap = FindObjectOfType<Tilemap>();
        Debug.Log(tilemap.name);
    }

    public void GenerateInitialSector()
    {
        DateTime before = DateTime.Now;



        DateTime after = DateTime.Now;
        TimeSpan duration = after.Subtract(before);
        Debug.Log("Duration in milliseconds: " + duration.Milliseconds);
    }

    public void GetAllChunks()
    {
        foreach(Transform sector in transform)
        {
            foreach(Transform chunk in sector)
            {
                foreach(Transform tile in chunk)
                {
                    tile.localScale = new Vector3(1,1,1);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
