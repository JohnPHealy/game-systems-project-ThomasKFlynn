using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    bool triggered = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && triggered)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }

    }

    private void OnTriggerEnter(Collider NPC)
    {
        if (NPC.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Cursor.lockState = CursorLockMode.None;
        }
        Debug.Log("Triggered");
    }

    private void OnTriggerExit(Collider NPC)
    {
        if (NPC.gameObject.CompareTag("Player"))
        {
            triggered = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        Debug.Log("Not Triggered");
    }
}
