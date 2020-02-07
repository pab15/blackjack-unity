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

    public void OnClickDealHand()
    {
        deck = setDeck();
        ShuffleDeck(deck);
        DealCard(ref playerHand);
        DealCard(ref dealerHand);
        DealCard(ref playerHand);
        DealCard(ref dealerHand);

        print("Player Hand: ");
        foreach (string card in playerHand)
        {
            print(card);
        }
        print("Dealer Hand: ");
        foreach (string card in dealerHand)
        {
            print(card);
        }
        PutCardsBack();
        print(deck.Count);
    }

    // From: https://www.youtube.com/watch?v=1Cmb181-quI:
    public List<string> setDeck()
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
    void ShuffleDeck<T>(List<T> list)
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
}
