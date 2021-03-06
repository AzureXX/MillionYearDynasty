﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerStats : MonoBehaviour
{
    Player player;
    [SerializeField] Text dexterityText;
    [SerializeField] Text enduranceText;
    [SerializeField] Text intellectText;
    [SerializeField] Text strengthText;

    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance;
       
    }

    // Update is called once per frame
    void Update()
    {
        dexterityText.text = "Dexterity:" + player.DexterityExp;
        enduranceText.text = "Endurance:" + player.EnduranceExp;
        intellectText.text = "Intellect:" + player.IntellectExp;
        strengthText.text = "Strength:" + player.StrengthExp;
    }
}
