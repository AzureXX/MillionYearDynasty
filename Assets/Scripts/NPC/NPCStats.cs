﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "NPCStats")]
public class NPCStats : ScriptableObject
{


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
    [SerializeField] int _health = 100;
    [SerializeField] int _hunger = 100;
    [SerializeField] int _energy = 100;
    [SerializeField] int _thirst = 100;
    [SerializeField] int _aggression = 100;
    [Header("Stats")]
    [SerializeField] int _dexterityExp = 0;
    [SerializeField] int _enduranceExp = 0;
    [SerializeField] int _intellectExp = 0;
    [SerializeField] int _strengthExp = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
