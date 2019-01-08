using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creatures : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] int health = 100;
    [SerializeField] int hunger = 100;
    [SerializeField] int energy = 100;
    [SerializeField] int thirst = 100;
    [SerializeField] int aggressiveness = 0;
    [Header("Stats")]
    [SerializeField] int dexterityExp = 0;
    [SerializeField] int enduranceExp = 0;
    [SerializeField] int intellectExp = 0;
    [SerializeField] int strengthExp = 0;


    public int GetHealth => health;
    public void SetHealth(int value)
    {
        health = value;
    }

    public int GetHunger => hunger;
    public void SetHunger(int value)
    {
        hunger = value;
    }

    public int GetThirst => thirst;
    public void SetThirst(int value)
    {
        thirst = value;
    }

    public int GetEnergy => energy;
    public void SetEnergy(int value)
    {
        energy = value;
    }

    public int GetAggressiveness => aggressiveness;
    public void SetAggressiveness(int value)
    {
        aggressiveness = value;
    }

    public int GetDexterityExp => dexterityExp;
    public void SetDexterityExp(int value)
    {
        dexterityExp = value;
    }

    public int GetEnduranceExp => enduranceExp;
    public void SetEnduranceExp(int value)
    {
        enduranceExp = value;
    }

    public int GetIntellectExp => intellectExp;
    public void SetIntellectExp(int value)
    {
        intellectExp = value;
    }

    public int GetStrengthExp => strengthExp;
    public void SetStrengthExp(int value)
    {
        strengthExp = value;
    }



}
