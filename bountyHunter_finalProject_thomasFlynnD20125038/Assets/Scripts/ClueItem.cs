using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClueItem : MonoBehaviour
{
    public interface cClueItem
    {
        string Name { get; }
        Sprite Image { get; }

        void OnPickup();
    }

    public class ClueEventArgs : EventArgs
    {
        public ClueEventArgs(cClueItem item)
        {
            Item = item;
        }

        public cClueItem Item;
    }

}
