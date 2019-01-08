using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public void GatherWood()
    {
        GetComponent<Inventory>().AddItem(Resources.Load("Wood") as Item, 3);
    }

    public void GatherStone()
    {
        GetComponent<Inventory>().AddItem(Resources.Load("Stone") as Item, 3);
    }

    public void TrainStrength()
    {
        GetComponent<Creatures>().SetStrengthExp(GetComponent<Creatures>().GetStrengthExp + 5);

    }
}
