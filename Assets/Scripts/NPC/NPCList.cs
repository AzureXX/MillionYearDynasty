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

    public void AddNPC()
    {
        GameObject npc = Resources.Load("NPC/NPC") as GameObject;
        GameObject newNPC = Instantiate(npc, new Vector3(0, 0, 0), Quaternion.identity);
        newNPC.transform.parent = transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
