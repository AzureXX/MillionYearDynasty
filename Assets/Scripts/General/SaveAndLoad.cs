using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveAndLoad : MonoBehaviour
{
    public void Save()
    {
        Debug.Log("Saving to:" + Application.persistentDataPath);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.OpenOrCreate);
        PlayerData data = new PlayerData();
        Creatures playerCreature = Player.instance.GetComponent<Creatures>();
        data.health = playerCreature.GetHealth;
        data.hunger = playerCreature.GetHunger;
        data.energy = playerCreature.GetEnergy;
        data.thirst = playerCreature.GetThirst;
        data.aggression = playerCreature.GetAggression;
        data.dexterityExp = playerCreature.GetDexterityExp;
        data.enduranceExp = playerCreature.GetEnduranceExp;
        data.intellectExp = playerCreature.GetIntellectExp;
        data.strengthExp = playerCreature.GetStrengthExp;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = bf.Deserialize(file) as PlayerData;
            file.Close();
            Creatures playerCreature = Player.instance.GetComponent<Creatures>();
            playerCreature.SetHealth(data.health);
            playerCreature.SetEnergy(data.energy);
            playerCreature.SetHunger(data.hunger);
            playerCreature.SetThirst(data.thirst);
            playerCreature.SetAggression(data.aggression);
            playerCreature.SetDexterityExp(data.dexterityExp);
            playerCreature.SetEnduranceExp(data.enduranceExp);
            playerCreature.SetIntellectExp(data.intellectExp);
            playerCreature.SetStrengthExp(data.strengthExp);
        }
    }
}

[Serializable]
class PlayerData
{
    public int health = 100;
    public int hunger = 100;
    public int energy = 100;
    public int thirst = 100;
    public int aggression = 0;

    public int dexterityExp = 0;
    public int enduranceExp = 0;
    public int intellectExp = 0;
    public int strengthExp = 0;
}