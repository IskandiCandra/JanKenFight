using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{

    enum element {Scissor = 1,Paper = 2 , Rock = 3}

    private int playerChoose = -1;
    private int botChoose = -1;

    private bool playersTurn = true ;

    public GameObject WinnerText;

    public Sprite paperImage, rockImage, scissorImage;
    public GameObject botChooseImage;

    // Update is called once per frame
    void Update()
    {
        if (playersTurn && playerChoose == -1)
        {
            return;
        }


        
    }

    public void CheckWinner()
    {
        if (playerChoose == botChoose)
        {
            WinnerText.GetComponent<Text>().text = "DRAW";
        }

        else if (playerChoose == (int)element.Paper && botChoose == (int)element.Rock)
        {
            WinnerText.GetComponent<Text>().text = "WINNER";
        }

        else if (playerChoose == (int)element.Rock && botChoose == (int)element.Paper)
        {
            WinnerText.GetComponent<Text>().text = "LOSE";
        }

        else if (playerChoose == (int)element.Scissor && botChoose == (int)element.Paper)
        {
            WinnerText.GetComponent<Text>().text = "WINNER";
        }

        else if (playerChoose == (int)element.Paper && botChoose == (int)element.Scissor)
        {
            WinnerText.GetComponent<Text>().text = "LOSE";
        }

        else if (playerChoose == (int)element.Rock && botChoose == (int)element.Scissor)
        {
            WinnerText.GetComponent<Text>().text = "WINNER";
        }

        else if (playerChoose == (int)element.Scissor && botChoose == (int)element.Rock)
        {
            WinnerText.GetComponent<Text>().text = "LOSE";
        }

        
    }

    public void PlayerChoose(int choose)
    {
        playerChoose = choose;
        playersTurn = false;

        BotChoose();
        CheckWinner();
        playerChoose = -1;
        playersTurn = true;
    }

    public void BotChoose()
    {
        botChoose = Random.Range(1,4);

        if (botChoose == 1)
        {
            botChooseImage.GetComponent<Image>().sprite = scissorImage ; 
        }

        else if (botChoose == 2)
        {
            botChooseImage.GetComponent<Image>().sprite = paperImage;
        }
        else
        {
            botChooseImage.GetComponent<Image>().sprite = rockImage; 
        }

    }
    
   
	
}
