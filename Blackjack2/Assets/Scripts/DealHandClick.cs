using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealHandClick : MonoBehaviour
{ 
    private string[] suits = { "C", "D", "H", "S" };
    private string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    private List<string> deck;
    private List<string> playerHand = new List<string>();
    private List<string> dealerHand = new List<string>();

    private int playerMoney = 20;
    private int dealerMoney = 20;
    private int playerHandCount = 0;
    private int dealerHandCount = 0;

    private bool playerWin;
    private bool tie = false;
    private bool playerTurn = true;
    private bool dealerTurn = false;
    private bool dealerHit = false;

    public void OnClickDealHand()
    {
        deck = setDeck();
        ShuffleDeck(deck);
        DealCard(ref playerHand);
        DealCard(ref dealerHand);
        DealCard(ref playerHand);
        DealCard(ref dealerHand);

        DealerTurn();
        print("Dealer Hand: ");
        foreach (string card in dealerHand)
        {
            print(card);
        }
        print("Dealer Hand Count: ");
        print(dealerHandCount);
        print("Player Win: ");
        print(playerWin);
        PutCardsBack();
        print(deck.Count);
    }

    // From: https://www.youtube.com/watch?v=1Cmb181-quI:
    private  List<string> setDeck()
    {
        List<string> result = new List<string>();
        foreach (string suit in suits)
        {
            foreach (string value in values)
            {
                result.Add(suit + value);
            }
        }
        return result;
    }

    // From: https://www.youtube.com/watch?v=1Cmb181-quI:
    private void ShuffleDeck<T>(List<T> list)
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

    private void DealCard(ref List<string> handToDeal)
    {
        handToDeal.Add(deck[0]);
        deck.RemoveAt(0);
    }

    private void PutCardsBack()
    {
        foreach(string card in playerHand)
        {
            deck.Add(card);
        }
        foreach(string card in dealerHand)
        {
            deck.Add(card);
        }
        playerHand.Clear();
        dealerHand.Clear();
    }

    private void DealerTurn()
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

    private void DealerHit()
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

    private int FetchCardValue(string card)
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
