using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameObject startButton;
    public static GameObject deckSprite;
    public static GameObject dealButton;
    public static GameObject hitButton;
    public static GameObject stayButton;
    public static GameObject betButton;
    public static GameObject betInput;
    public static GameObject deckInput;

    public static string[] suits = { "C", "D", "H", "S" };
    public static string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    public static int numDecks;
    public static List<string> deck;
    public static List<string> playerHand = new List<string>();
    public static List<string> dealerHand = new List<string>();

    public static int playerMoney = 20;
    public static int dealerMoney = 20;
    public static int playerHandCount = 0;
    public static int dealerHandCount = 0;

    public static bool playerWin;
    public static bool hasBet = false;
    public static bool tie = false;
    public static bool playerTurn = true;
    public static bool dealerTurn = false;
    public static bool dealerHit = false;
    public static bool playerHit = false;


    void Start()
    {
        startButton = GameObject.Find("StartButton");
        deckSprite = GameObject.Find("Deck");
        dealButton = GameObject.Find("DealHand");
        hitButton = GameObject.Find("Hit");
        stayButton = GameObject.Find("Stay");
        betButton = GameObject.Find("Bet");
        betInput = GameObject.Find("BetInput");
        deckInput = GameObject.Find("DeckInput");

        deckSprite.SetActive(false);
        dealButton.SetActive(false);
        hitButton.SetActive(false);
        stayButton.SetActive(false);
        betButton.SetActive(false);
        betInput.SetActive(false);
    }

    // From: https://www.youtube.com/watch?v=1Cmb181-quI:
    public static List<string> setDeck()
    {
        List<string> result = new List<string>();

        for (int i = 0; i < numDecks; i++)
        {
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    result.Add(suit + value);
                }
            }
        }
        
        return result;
    }

    // From: https://www.youtube.com/watch?v=1Cmb181-quI:
    public static void ShuffleDeck<T>(List<T> list)
    {
        System.Random random = new System.Random();

        int n = list.Count;

        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

    public static void DealCard(ref List<string> handToDeal)
    {
        handToDeal.Add(deck[0]);
        deck.RemoveAt(0);
    }

    public static void PutCardsBack()
    {
        foreach (string card in playerHand)
        {
            deck.Add(card);
        }
        foreach (string card in dealerHand)
        {
            deck.Add(card);
        }
        playerHand.Clear();
        dealerHand.Clear();
    }

    public static void PlayerTurn()
    {
        foreach (string card in playerHand)
        {
            playerHandCount += FetchCardValue(card);
        }
    }

    public static void PlayerHit()
    {
        int position = 2;

        while (playerHit)
        {
            DealCard(ref playerHand);
            playerHandCount += FetchCardValue(playerHand[position]);
            if (playerHandCount > 21)
            {
                playerHit = false;
                playerWin = true;
            }
            position++;
        }
    }

    public static void DealerTurn()
    {
        foreach (string card in dealerHand)
        {
            dealerHandCount += FetchCardValue(card);
        }

        if (dealerHandCount < 17)
        {
            dealerHit = true;
            DealerHit();
        }

        if (playerWin == true)
            playerWin = true;
        else if (dealerHandCount > playerHandCount)
            playerWin = false;
        else if (dealerHandCount < playerHandCount)
            playerWin = true;
        else if (dealerHandCount == playerHandCount)
            tie = true;
    }

    public static void DealerHit()
    {
        int position = 2;
        while (dealerHit == true)
        {
            DealCard(ref dealerHand);
            dealerHandCount += FetchCardValue(dealerHand[position]);
            if (dealerHandCount > 17 && dealerHandCount <= 21)
                dealerHit = false;
            else if (dealerHandCount > 21)
            {
                dealerHit = false;
                playerWin = true;
            }
            position++;
        }
    }

    public static int FetchCardValue(string card)
    {
        string value = card.Substring(1);

        switch (value)
        {
            case "2":
                return 2;
            case "3":
                return 3;
            case "4":
                return 4;
            case "5":
                return 5;
            case "6":
                return 6;
            case "7":
                return 7;
            case "8":
                return 8;
            case "9":
                return 9;
            case "10":
            case "J":
            case "Q":
            case "K":
                return 10;
            case "A":
                return 11;
            default:
                return 0;
        }
    }
}
