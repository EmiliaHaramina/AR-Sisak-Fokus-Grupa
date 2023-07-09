using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int questionNumber;
    private int lastQuestionNumber;

    private ButtonScript lastButton;

    private GameObject currentChat;

    // Start is called before the first frame update
    void Start()
    {
        questionNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setActiveChat(GameObject chat)
    {
        currentChat = chat;
    }

    public void HideLastAnswerDialogue()
    {
        if(currentChat != null && questionNumber != lastQuestionNumber) 
        {
            currentChat.SetActive(false);
        }
    }

    public void hideLastChat()
    {
        if(currentChat != null) 
        {
            currentChat.SetActive(false);
        }
    }

    public void setQuestionNumber(int number)
    {
        lastQuestionNumber = questionNumber;
        questionNumber = number;
    }

    public int getQuestionNumber()
    {
        return questionNumber;
    }

    public void SetLastButton(ButtonScript button)
    {
        if (lastButton != null)
        {
            lastButton.DisableHighlight();
        }
        lastButton = button;
        lastButton.EnableHighlight();
    }

}
