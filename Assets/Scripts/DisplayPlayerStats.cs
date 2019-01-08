using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerStats : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Text strengthText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        strengthText.text = "Strength:" + player.GetComponent<Creatures>().GetStrengthExp;
    }
}
