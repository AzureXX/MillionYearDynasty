using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCActions : MonoBehaviour
{
    // Start is called before the first frame update
    public void MakeAMove()
    {
        Vector3 npcPos = gameObject.transform.position;
        gameObject.transform.position = new Vector3(npcPos.x + 1, npcPos.y + 1, npcPos.z);
    }
}
