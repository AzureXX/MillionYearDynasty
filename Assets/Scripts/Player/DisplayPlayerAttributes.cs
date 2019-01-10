using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayPlayerAttributes : MonoBehaviour
{
    Player player;
    Creatures playerCreature;
    [SerializeField] Text healthText;
    [SerializeField] Text energyText;
    [SerializeField] Text hungerText;
    [SerializeField] Text thirstText;
    [SerializeField] Text aggressionText;

    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance;
        playerCreature = player.GetComponent<Creatures>();

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health:" + playerCreature.GetHealth;
        energyText.text = "Energy:" + playerCreature.GetEnergy;
        hungerText.text = "Hunger:" + playerCreature.GetHunger;
        thirstText.text = "Thirst:" + playerCreature.GetThirst;
        aggressionText.text = "Aggression:" + playerCreature.GetAggression;
    }
}
