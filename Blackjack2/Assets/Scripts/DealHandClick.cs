using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealHandClick : MonoBehaviour
{
    public void OnClickDealHand()
    {
        GameManager.hitButton.SetActive(true);
        GameManager.stayButton.SetActive(true);
        GameManager.betButton.SetActive(true);
        GameManager.betInput.SetActive(true);
        GameManager.dealButton.SetActive(false);

        GameManager.deck = GameManager.setDeck();
        GameManager.ShuffleDeck(GameManager.deck);
        GameManager.DealCard(ref GameManager.playerHand, GameManager.playerSpace);
        GameManager.DealCard(ref GameManager.dealerHand, GameManager.opponentSpace);
        GameManager.DealCard(ref GameManager.playerHand, GameManager.playerSpace);
        GameManager.DealCard(ref GameManager.dealerHand, GameManager.opponentSpace);

        if (GameManager.playerTurn == true)
            GameManager.PlayerTurn();
        GameManager.DealerTurn();
        print("Player Hand: ");
        foreach (string card in GameManager.playerHand)
        {
            print(card);
        }
        print("Dealer Hand: ");
        foreach (string card in GameManager.dealerHand)
        {
            print(card);
        }
        print("Player Hand Count: ");
        print(GameManager.playerHandCount);
        print("Dealer Hand Count: ");
        print(GameManager.dealerHandCount);
        print("Player Win: ");
        print(GameManager.playerWin);
        GameManager.PutCardsBack();
        print(GameManager.deck.Count);
        print(GameManager.numDecks);
    }
}
