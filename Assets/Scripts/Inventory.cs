using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventorySlot> ItemList { get;  } = new List<InventorySlot>();

    // Start is called before the first frame update

    public class InventorySlot
    {
        public Item item;
        public int amount;
        public InventorySlot(Item item, int amount)
        {
            this.item = item;
            this.amount = amount;
        }
    }

    public void AddItem(Item item, int amount)
    {
        int index = ItemList.FindIndex(row => row.item == item);
        if(index > -1)
        {
            ItemList[index].amount += amount;
        }
        else
        {
            InventorySlot newInventorySlot = new InventorySlot(item, amount);
            ItemList.Add(newInventorySlot);
        }

    }

}
