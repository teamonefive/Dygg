﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CraftingButton : MonoBehaviour
{

    [SerializeField] private Button button;
    [SerializeField] private Item1 _item;
    [SerializeField] private Text nameLabel;
    [SerializeField] private Text craftingRecipe;
    [SerializeField] private Image iconImage;
    [SerializeField] private int itemID;
    [SerializeField] private CraftingInfo _info;
    [SerializeField] private GameObject infoPanel;



    // Start is called before the first frame update
    void Start()
    {
        if (_item.MyTitle == "Iron Ingot") {
            IngotIron ironIngot = (IngotIron)Instantiate(_item);
        }
        else if (_item.MyTitle == "Silver Ingot") {
            IngotSilver silverIngot = (IngotSilver)Instantiate(_item);
        }
        else if (_item.MyTitle == "Gold Ingot") {
            IngotGold goldIngot = (IngotGold)Instantiate(_item);
        }
        else if (_item.MyTitle == "Mithril Ingot") {
            IngotMithril mithrilIngot = (IngotMithril)Instantiate(_item);
        }
        else if (_item.MyTitle == "Iron Pickaxe" ) {
            IronPickAxe ironPickaxe = ( IronPickAxe )Instantiate(_item);
        }
        else if(_item.MyTitle == "Silver Pickaxe" ) {
            SilverPickAxe silverPickaxe = ( SilverPickAxe )Instantiate(_item);
        }
        else if(_item.MyTitle == "Gold Pickaxe" ) {
            GoldPickAxe goldPickaxe = ( GoldPickAxe )Instantiate(_item);
        }
        else if(_item.MyTitle == "Mithril Pickaxe" ) {
            DiamondPickAxe diamondPickaxe = ( DiamondPickAxe )Instantiate(_item);
        }
        else if (_item.MyTitle == "Rune of Teleportation")
        {
            Teleporter teleporter = (Teleporter)Instantiate(_item);
        }
        nameLabel.text = _item.MyTitle;
        iconImage.sprite = _item.MyIcon;
        craftingRecipe.text = _item.MyRecipe;
        

    }
    public void DisplayInfo() {
        infoPanel.SetActive(true);
        _info.updateItem(_item);
        //InventoryScript.MyInstance.AddItem(_item);
    }


    
}
