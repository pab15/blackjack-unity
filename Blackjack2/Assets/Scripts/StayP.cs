using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayP : MonoBehaviour
{
    public void OnClickStay()
    {
        GameManager.playerTurn = false;
        GameManager.DealCard(ref GameManager.dealerHand, GameManager.opponentSpace);
        GameManager.DealCard(ref GameManager.dealerHand, GameManager.opponentSpace);
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
    }
}
