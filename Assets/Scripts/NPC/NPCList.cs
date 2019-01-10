using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCList : MonoBehaviour
{
    #region Singleton
    public static NPCList instance = null;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
