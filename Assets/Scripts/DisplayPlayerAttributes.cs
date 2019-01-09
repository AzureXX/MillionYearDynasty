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
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {

        healthText.text = "Health:" + player.GetComponent<Creatures>().GetHealth;
        energyText.text = "Energy:" + player.GetComponent<Creatures>().GetEnergy;
        hungerText.text = "Hunger:" + player.GetComponent<Creatures>().GetHunger;
        thirstText.text = "Thirst:" + player.GetComponent<Creatures>().GetThirst;
        aggressionText.text = "Aggression:" + player.GetComponent<Creatures>().GetAggression;
    }
}
