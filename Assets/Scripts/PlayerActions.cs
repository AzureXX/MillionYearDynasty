using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public void GatherWood()
    {
        if (ChangeEnergy(-5))
        {
            GetComponent<Inventory>().AddItem(Resources.Load("Wood") as Item, 3);
        }
    }

    public void GatherStone()
    {
        if (ChangeEnergy(-5))
        {
            GetComponent<Inventory>().AddItem(Resources.Load("Stone") as Item, 3);
        }
    }

    public void TrainDexterity()
    {
        if (ChangeEnergy(-5))
        {
            GetComponent<Creatures>().SetDexterityExp(GetComponent<Creatures>().GetDexterityExp + 5);
        }
    }
    public void TrainEndurance()
    {
        if (ChangeEnergy(-5))
        {
            GetComponent<Creatures>().SetEnduranceExp(GetComponent<Creatures>().GetEnduranceExp + 5);
        }
    }
    public void TrainIntellect()
    {
        if (ChangeEnergy(-5))
        {
            GetComponent<Creatures>().SetIntellectExp(GetComponent<Creatures>().GetIntellectExp + 5);
        }
    }
    public void TrainStrength()
    {
        if (ChangeEnergy(-5))
        {
            GetComponent<Creatures>().SetStrengthExp(GetComponent<Creatures>().GetStrengthExp + 5);
        }

    }

    public void Rest()
    {
        ChangeEnergy(10);
    }
    private bool ChangeEnergy(int value)
    {
        if (GetComponent<Creatures>().GetEnergy + value >= 0) 
        {
            GetComponent<Creatures>().SetEnergy(GetComponent<Creatures>().GetEnergy + value);
            return true;
        }
        else
        {
            return false;
        }
    }
}
