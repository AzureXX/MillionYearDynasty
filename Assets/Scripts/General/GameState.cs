using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{

    [SerializeField] int date = 0;
    public static GameState instance = null;

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

    // Start is called before the first frame update
    public void NextDate()
    {
        date++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

