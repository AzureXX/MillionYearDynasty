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
        newNPC.transform.position = new Vector3(Random.Range(0, 121), Random.Range(0, 121), -1);
    }

    public void MakeAllNPCActions()
    {
        foreach (Transform npc in transform)
        {
            npc.GetComponent<NPCActions>().MakeAMove();
        }
    }

}
