using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<InventorySlot> itemList = new List<InventorySlot>();

    public List<InventorySlot> GetItemList => itemList;

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
        bool exist = itemList.Exists(row => row.item == item);
        if(exist)
        {
            foreach(InventorySlot row in itemList)
            {
                if(row.item == item)
                {
                    row.amount += amount;
                }
            }
        }
        else
        {
            InventorySlot newInventorySlot = new InventorySlot(item, amount);
            itemList.Add(newInventorySlot);
        }

    }

}
