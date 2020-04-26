﻿using UnityEngine;
using UnityEngine.UI;

public class LuckMinus : MonoBehaviour
{
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        image.enabled = false;
    }

    void Update()
    {
        // If we leveled and a point was put in our stat, show minus button.
        if (Experience.MyInstance.isLvling && Experience.MyInstance.lucUp > 0)
        {
            image.enabled = true;
        }
        else
        {
            image.enabled = false;
        }
    }

    public void LuckDown()
    {
        if (Experience.MyInstance.isLvling && Experience.MyInstance.lucUp > 0)
        {
            Experience.MyInstance.lucUp -= 1;
            Experience.MyInstance.statPoints--;
        }
    }
}

