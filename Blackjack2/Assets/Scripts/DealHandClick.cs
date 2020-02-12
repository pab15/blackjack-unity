using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealHandClick : MonoBehaviour
{
    public void OnClickDealHand()
    {
        GameManager.betButton.SetActive(true);
        GameManager.betInput.SetActive(true);
        GameManager.playerHandObj.SetActive(true);
        GameManager.dealerHandObj.SetActive(true);
        GameManager.dealButton.SetActive(false);

        GameManager.deck = GameManager.setDeck();
        GameManager.ShuffleDeck(GameManager.deck);
        GameManager.DealCard(ref GameManager.playerHand, GameManager.playerSpace);
        GameManager.DealCard(ref GameManager.playerHand, GameManager.playerSpace);
        GameManager.PlayerTurn();
    }

    void Update()
    {
        
    }
}
