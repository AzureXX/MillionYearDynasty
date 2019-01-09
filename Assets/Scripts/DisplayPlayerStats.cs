using System.Collections;
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
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        dexterityText.text = "Dexterity:" + player.GetComponent<Creatures>().GetDexterityExp;
        enduranceText.text = "Endurance:" + player.GetComponent<Creatures>().GetEnduranceExp;
        intellectText.text = "Intellect:" + player.GetComponent<Creatures>().GetIntellectExp;
        strengthText.text = "Strength:" + player.GetComponent<Creatures>().GetStrengthExp;
    }
}
