﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    Player player;
    Creatures playerCreature;
    
    void Start()
    {
        player = Player.instance ;
        playerCreature = player.GetComponent<Creatures>();
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
            playerCreature.SetDexterityExp(playerCreature.GetDexterityExp + 5);
        }
    }
    public void TrainEndurance()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            playerCreature.SetEnduranceExp(playerCreature.GetEnduranceExp + 5);
        }
    }
    public void TrainIntellect()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            playerCreature.SetIntellectExp(playerCreature.GetIntellectExp + 5);
        }
    }
    public void TrainStrength()
    {

        if (ChangeEnergy(-5))
        {
            GameState.instance.NextDate();
            playerCreature.SetStrengthExp(playerCreature.GetStrengthExp + 5);
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

        if (playerCreature.GetEnergy + value >= 0) 
        {
            playerCreature.SetEnergy(playerCreature.GetEnergy + value);
            return true;
        }
        else
        {
            return false;
        }

    }
}
