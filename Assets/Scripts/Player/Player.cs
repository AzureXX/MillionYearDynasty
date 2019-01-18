using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : Creature
{
    #region Singleton
    public static Player instance = null;

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


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y, -10f);
        NewMethod();
    }

    private static void NewMethod()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            FindObjectOfType<PlayerActions>().GoSouth();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            FindObjectOfType<PlayerActions>().GoNorth();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            FindObjectOfType<PlayerActions>().GoEast();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            FindObjectOfType<PlayerActions>().GoWest();
        }
    }
}
