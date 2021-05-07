using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClue : MonoBehaviour
{
    public AudioSource collectSound;
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        CluesFound.numberOfClues += 1;
        Destroy(gameObject);
    }
}
