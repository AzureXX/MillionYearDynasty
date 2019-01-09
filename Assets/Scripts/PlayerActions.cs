using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    public void GatherWood()
    {
        if (ChangeEnergy(-5))
        {
            player.GetComponent<Inventory>().AddItem(Resources.Load("Wood") as Item, 3);
        }
    }

    public void GatherStone()
    {
        if (ChangeEnergy(-5))
        {
            player.GetComponent<Inventory>().AddItem(Resources.Load("Stone") as Item, 3);
        }
    }

    public void TrainDexterity()
    {
        if (ChangeEnergy(-5))
        {
            player.GetComponent<Creatures>().SetDexterityExp(player.GetComponent<Creatures>().GetDexterityExp + 5);
        }
    }
    public void TrainEndurance()
    {
        if (ChangeEnergy(-5))
        {
            player.GetComponent<Creatures>().SetEnduranceExp(player.GetComponent<Creatures>().GetEnduranceExp + 5);
        }
    }
    public void TrainIntellect()
    {
        if (ChangeEnergy(-5))
        {
            player.GetComponent<Creatures>().SetIntellectExp(player.GetComponent<Creatures>().GetIntellectExp + 5);
        }
    }
    public void TrainStrength()
    {
        if (ChangeEnergy(-5))
        {
            player.GetComponent<Creatures>().SetStrengthExp(player.GetComponent<Creatures>().GetStrengthExp + 5);
        }

    }

    public void Rest()
    {
        ChangeEnergy(10);
    }
    private bool ChangeEnergy(int value)
    {
        if (player.GetComponent<Creatures>().GetEnergy + value >= 0) 
        {
            player.GetComponent<Creatures>().SetEnergy(player.GetComponent<Creatures>().GetEnergy + value);
            return true;
        }
        else
        {
            return false;
        }
    }
}
