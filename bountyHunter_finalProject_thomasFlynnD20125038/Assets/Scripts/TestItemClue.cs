using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItemClue : MonoBehaviour
{
    public string Name
    {
        get
        {
            return "Test Clue";
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickup()
    {
        //add logic what happens when picked up by player
        gameObject.SetActive(false);
    }
}
