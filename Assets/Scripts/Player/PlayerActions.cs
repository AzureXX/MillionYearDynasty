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
            player.GetComponent<Creatures>().SetDexterityExp(player.GetComponent<Creatures>().GetDexterityExp + 5);
        }
    }
    public void TrainEndurance()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            player.GetComponent<Creatures>().SetEnduranceExp(player.GetComponent<Creatures>().GetEnduranceExp + 5);
        }
    }
    public void TrainIntellect()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            player.GetComponent<Creatures>().SetIntellectExp(player.GetComponent<Creatures>().GetIntellectExp + 5);
        }
    }
    public void TrainStrength()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            player.GetComponent<Creatures>().SetStrengthExp(player.GetComponent<Creatures>().GetStrengthExp + 5);
        }

    }

    public void Rest()
    {
        GameState.instance.NextDate();
        ChangeEnergy(10);
    }

    public void AddCitizen()
    {

        GameObject npc = Resources.Load("NPC/NPC") as GameObject;
        Instantiate(npc, new Vector3(0, 0, 0), Quaternion.identity);
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
