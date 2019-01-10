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
        data.health = Player.instance.Health;
        data.hunger = Player.instance.Hunger;
        data.energy = Player.instance.Energy;
        data.thirst = Player.instance.Thirst;
        data.aggression = Player.instance.Aggression;
        data.dexterityExp = Player.instance.DexterityExp;
        data.enduranceExp = Player.instance.EnduranceExp;
        data.intellectExp = Player.instance.IntellectExp;
        data.strengthExp = Player.instance.StrengthExp;

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
            Player.instance.Health = data.health;
            Player.instance.Energy = data.energy;
            Player.instance.Hunger = data.hunger;
            Player.instance.Thirst = data.thirst;
            Player.instance.Aggression = data.aggression;
            Player.instance.DexterityExp = data.dexterityExp;
            Player.instance.EnduranceExp = data.enduranceExp;
            Player.instance.IntellectExp = data.intellectExp;
            Player.instance.StrengthExp = data.strengthExp;
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