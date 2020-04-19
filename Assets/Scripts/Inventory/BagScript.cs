﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScript : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;

    private CanvasGroup canvasGroup;

    private List<SlotScript> slots = new List<SlotScript>();

    public bool IsOpen
    {
        get
        {
            return canvasGroup.alpha > 0;
        }
    }

    public List<SlotScript> MySlots
    {
        get
        {
            return slots;
        }
    }

    public int MyEmptySlotCount
    {
        get
        {
            int count = 0;

            foreach(SlotScript slot in MySlots)
            {
                if(slot.IsEmpty)
                {
                    count++;
                }
            }
            return count;
        }
    }

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public List<Item1> GetItems()
    {
        List<Item1> items = new List<Item1>();
        foreach (SlotScript slot in slots)
        {
            if(!slot.IsEmpty)
            {
                if(!slot.IsEmpty)
                {
                    foreach(Item1 item in slot.MyItems)
                    {
                        items.Add(item);
                    }
                }
            }
        }
        return items;
    }

    public void Addslots(int slotCount)
    {
        for(int i =0; i<slotCount; i++)
        {
            SlotScript slot = Instantiate(slotPrefab, transform).GetComponent<SlotScript>();
            slot.MyBag = this;
            slots.Add(slot);
        }
    }

    public bool AddItem(Item1 item)
    {
        foreach( SlotScript slot in slots)
        {
            if(slot.IsEmpty)
            {
                slot.AddItem(item);

                return true;
            }
        }
        return false;
    }

    public void OpenClose()
    {
        canvasGroup.alpha = canvasGroup.alpha>0 ? 0 :1 ;

        canvasGroup.blocksRaycasts = canvasGroup.blocksRaycasts == true ? false : true;
    }

}
