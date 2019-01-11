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
        
    }

    public void GenerateInitialSector()
    {
        Debug.Log("Generation of initial Sector started");
        sectors.Add(new Sector("Plain", new Vector2(0, 0)));
        Debug.Log("Generation of initial Sector ended");

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
