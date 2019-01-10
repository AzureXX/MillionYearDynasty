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

    [SerializeField] 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
