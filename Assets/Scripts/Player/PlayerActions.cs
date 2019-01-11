using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    Player player;
   
    
    void Start()
    {
        player = Player.instance ;

    }


    public void GatherWood()
    {

        if (ChangeEnergy(-5))
        {
            Debug.Log(player);
            GameState.instance.NextDate();
            player.GetComponent<Inventory>().AddItem(Resources.Load("Items/RawResources/Wood") as Item, 3);
        }
    }

    public void GatherStone()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            player.GetComponent<Inventory>().AddItem(Resources.Load("Items/RawResources/Stone") as Item, 3);
        }
    }

    public void TrainDexterity()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            player.DexterityExp += 5;
        }
    }
    public void TrainEndurance()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            player.EnduranceExp += 5;
        }
    }
    public void TrainIntellect()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            player.IntellectExp += 5;
        }
    }
    public void TrainStrength()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            player.StrengthExp += 5;
        }

    }

    public void Rest()
    {
        GameState.instance.NextDate();
        ChangeEnergy(10);
    }

    public void AddCitizen()
    {
        FindObjectOfType<NPCList>().AddNPC();
    }
    private bool ChangeEnergy(int value)
    {

        if (player.Energy + value >= 0) 
        {
            player.Energy += value;
            return true;
        }
        else
        {
            return false;
        }

    }
}
