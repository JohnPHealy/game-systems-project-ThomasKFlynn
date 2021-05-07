using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CluesFound : MonoBehaviour
{
    public GameObject cluesFound;
    public static int numberOfClues;

    private void Update()
    {
        cluesFound.GetComponent<Text>().text = "Clues Found: " + numberOfClues + "/3";

        if (numberOfClues >= 3)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

}
