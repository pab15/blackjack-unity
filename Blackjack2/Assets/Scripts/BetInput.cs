using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetInput : MonoBehaviour
{
    public void BetHandler(int index)
    {
        switch (index)
        {
            case 1:
                GameManager.playerBet = 1;
                break;
            case 2:
                GameManager.playerBet = 5;
                break;
            case 3:
                GameManager.playerBet = 10;
                break;
            case 4:
                GameManager.playerBet = 25;
                break;
            case 5:
                GameManager.playerBet = 50;
                break;
            case 6:
                GameManager.playerBet = 100;
                break;
            case 7:
                GameManager.playerBet = GameManager.playerMoney;
                break;
        }
    }
}
