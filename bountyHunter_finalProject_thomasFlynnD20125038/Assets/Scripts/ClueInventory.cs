using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClueInventory : MonoBehaviour
{
    private const int SLOTS = 3;

    private List<ClueItem> mItems = new List<ClueItem>();

    public event EventHandler<ClueEventArgs> ItemAdded;

    public void AddItem(cClueItem item)
    {
        if(mItems.Count < SLOTS)
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;

                mItems.Add(item);

                item.OnPickup();

                if (ItemAdded != null)
                {
                    ItemAdded(this, new ClueEventArgs(item));
                }
            }
        }
    }
}
