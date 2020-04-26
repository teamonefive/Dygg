﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Bag", menuName ="Items/Bag", order=1)]
public class Bag : Item1,IUseable
{


    private int slots = 16;

    [SerializeField]
    protected GameObject bagPrefab;

    public BagScript MyBagScript { get; set; }

    public BagButton MyBagButton { get; set; }

    public int Slots
    {
        get
        {
            return slots;
        }
    }

    public void Initialize(int slots)
    {
        this.slots = slots;
    }

    public void Use()
    {
        if (InventoryScript.MyInstance.CanAddBag)
        {
            Remove();
            MyBagScript = Instantiate(bagPrefab, InventoryScript.MyInstance.transform).GetComponent<BagScript>();
            MyBagScript.Addslots(slots);

            InventoryScript.MyInstance.AddBag(this);
        }
    }
    
}

