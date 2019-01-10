using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerStats : MonoBehaviour
{
    Player player;
    Creatures playerCreature;
    [SerializeField] Text dexterityText;
    [SerializeField] Text enduranceText;
    [SerializeField] Text intellectText;
    [SerializeField] Text strengthText;

    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance;
        playerCreature = player.GetComponent<Creatures>();
    }

    // Update is called once per frame
    void Update()
    {
        dexterityText.text = "Dexterity:" + playerCreature.GetDexterityExp;
        enduranceText.text = "Endurance:" + playerCreature.GetEnduranceExp;
        intellectText.text = "Intellect:" + playerCreature.GetIntellectExp;
        strengthText.text = "Strength:" + playerCreature.GetStrengthExp;
    }
}
