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
        data.playerHealth = 5;
        data.playerEnergy = 100;

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

            Debug.Log(data.playerEnergy + ":" + data.playerHealth);
        }
    }
}

[Serializable]
class PlayerData
{
    public int playerHealth;
    public int playerEnergy;
}