using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClueItem : MonoBehaviour
{
    public interface clue
    {
        string Name { get; }
        Sprite Image { get; }

        void OnPickup();
    }

    public class ClueEventArgs : EventArgs
    {
        public ClueEventArgs(clue item)
        {
            Item = item;
        }

        public clue Item;
    }

}
