using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [SerializeField] NPCStats stats;

    public int Health { get => _health; set => _health = value; }
    public int Hunger { get => _hunger; set => _hunger = value; }
    public int Energy { get => _energy; set => _energy = value; }
    public int Thirst { get => _thirst; set => _thirst = value; }
    public int Aggression { get => _aggression; set => _aggression = value; }
    public int DexterityExp { get => _dexterityExp; set => _dexterityExp = value; }
    public int EnduranceExp { get => _enduranceExp; set => _enduranceExp = value; }
    public int IntellectExp { get => _intellectExp; set => _intellectExp = value; }
    public int StrengthExp { get => _strengthExp; set => _strengthExp = value; }

    [Header("Attributes")]
    [SerializeField] int _health;
    [SerializeField] int _hunger;
    [SerializeField] int _energy;
    [SerializeField] int _thirst;
    [SerializeField] int _aggression;
    [Header("Stats")]
    [SerializeField] int _dexterityExp;
    [SerializeField] int _enduranceExp;
    [SerializeField] int _intellectExp;
    [SerializeField] int _strengthExp;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
