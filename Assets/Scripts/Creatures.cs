using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creatures : MonoBehaviour
{

    [SerializeField] int health = 100;
    [SerializeField] int hunger = 100;
    [SerializeField] int thirst = 100;
    [SerializeField] int agressiveness = 0;
    [SerializeField] int strengthExp = 0;

    public int GetStrengthExp => strengthExp;
    public void SetStrengthExp(int value)
    {
        strengthExp = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        int strength = strengthExp / 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
