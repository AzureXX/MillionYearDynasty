using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayPlayerAttributes : MonoBehaviour
{
    Player player;
    [SerializeField] Text healthText;
    [SerializeField] Text energyText;
    [SerializeField] Text hungerText;
    [SerializeField] Text thirstText;
    [SerializeField] Text aggressionText;

    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance;


    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health:" + player.Health;
        energyText.text = "Energy:" + player.Energy;
        hungerText.text = "Hunger:" + player.Hunger;
        thirstText.text = "Thirst:" + player.Thirst;
        aggressionText.text = "Aggression:" + player.Aggression;
    }
}
