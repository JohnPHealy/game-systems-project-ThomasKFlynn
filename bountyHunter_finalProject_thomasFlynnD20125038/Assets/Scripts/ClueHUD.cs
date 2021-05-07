using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ClueHUD : MonoBehaviour
{
    public ClueInventory Inventory;

    private void Start()
    {
        Inventory.ItemAdded += ClueInventoryScript_ItemAdded;
    }

    private void ClueInventoryScript_ItemAdeed(object sender, ClueEventArgs e)
    {
        Transform cluesPanel = transform.Find("CluePanel");
        foreach(Transform slot in cluePanel)
        {
            Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();

            if (!image.enabled)
            {
                image.enabled - true;
                image.sprite = e.Item.Image;

                break;
            }
        }
    } 
}
