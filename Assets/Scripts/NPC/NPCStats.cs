using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "NPCStats")]
public class NPCStats : ScriptableObject
{

    [SerializeField] public int health = 100;
    [SerializeField] string race = "human";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
