﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    public GameObject dialogBox;
    public Text NameText;
    public Text dialogText;

    void Start()
    {
        sentences = new Queue<string>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with "+dialogue.name);
        dialogBox.SetActive(true);
        PlayerController.instance.gameObject.SetActive(false);

        NameText.text = dialogue.name;

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
        Debug.Log(sentence);
    }

    public void EndDialogue()
    {
        Debug.Log("End of conversation");
        dialogBox.SetActive(false);
        PlayerController.instance.gameObject.SetActive(true);
    }

   
}
