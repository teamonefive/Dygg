﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 revealPos;
    public Vector3 revealPos2;
    public TileBasedMover dwarf;
    public GameObject button;
    public GameObject buttonWindow;
    private bool craftTrig = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dwarf.oldPos == revealPos || dwarf.oldPos == revealPos2)
        {
            button.SetActive(true);
            if(craftTrig == true && (dwarf.oldPos == new Vector3(-49.5f, -1f, 0f) || dwarf.oldPos == new Vector3(-48.5f, -1f, 0f)))
            {
                FindObjectOfType<DialogueTrigger>().TriggerCraftingDialogue();
                craftTrig = false;
            }
        }
        else
        {
            button.SetActive(false);
            buttonWindow.SetActive(false);
        }
    }
}
