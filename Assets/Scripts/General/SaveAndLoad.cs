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
        PlayerData data = new PlayerData
        {
            health = Player.instance.Health,
            hunger = Player.instance.Hunger,
            energy = Player.instance.Energy,
            thirst = Player.instance.Thirst,
            aggression = Player.instance.Aggression,
            dexterityExp = Player.instance.DexterityExp,
            enduranceExp = Player.instance.EnduranceExp,
            intellectExp = Player.instance.IntellectExp,
            strengthExp = Player.instance.StrengthExp,
            posX = Player.instance.transform.position.x,
            posY = Player.instance.transform.position.y,
            posZ = Player.instance.transform.position.z
        };

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
            Player.instance.transform.position = new Vector3(data.posX, data.posY, data.posZ);
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
    public float posX = 0f;
    public float posY = 0f;
    public float posZ = -1f;
}