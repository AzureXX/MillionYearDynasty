using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Creature
{

    [SerializeField] NPCStats stats;


    // Start is called before the first frame update
    void Start()
    {
        stats = (NPCStats)Resources.Load("NPC/Human");
        Health = stats.Health;
        Hunger = stats.Hunger;
        Energy = stats.Energy;
        Thirst = stats.Thirst;
        Aggression = stats.Aggression;
        DexterityExp = stats.DexterityExp;
        EnduranceExp = stats.EnduranceExp;
        IntellectExp = stats.IntellectExp;
        StrengthExp = stats.StrengthExp;
        Id = ++GameState.instance.idCounter;
    }
}
