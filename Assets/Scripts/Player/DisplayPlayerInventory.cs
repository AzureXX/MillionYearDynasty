using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerInventory : MonoBehaviour
{
    Player player;

    [SerializeField] Text inventoryText;
    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance;
    }

    // Update is called once per frame
    void Update()
    {
        string newText = "Inventory: \n";
        var playerInventory = player.GetComponent<Inventory>().GetItemList;
        playerInventory.ForEach(item => {
            newText += item.item + ": " + item.amount + "\n";
        });
        inventoryText.text = newText;

    }
}
