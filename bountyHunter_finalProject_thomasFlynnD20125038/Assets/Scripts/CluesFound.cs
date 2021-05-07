using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CluesFound : MonoBehaviour
{
    public GameObject cluesFound;
    public int numberOfClues;
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        numberOfClues += 1;
        cluesFound.GetComponent<Text>().text = "Clues Found: " + numberOfClues + "/3";
        Destroy(gameObject);
    }
}
