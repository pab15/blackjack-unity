using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetButton : MonoBehaviour
{
    public void OnClickBet()
    {
        GameManager.hasBet = true;
        GameManager.playerMoney -= GameManager.playerBet;
        GameManager.betPool = GameManager.playerBet * 2;
        GameManager.dealerMoney -= GameManager.playerBet;
        GameManager.playerMoneyText.text = "Your Money: " + GameManager.playerMoney;
        GameManager.dealerMoneyText.text = "Dealer Money: " + GameManager.dealerMoney;
        GameManager.poolMoneyText.text = "Pool: " + GameManager.betPool;
        GameManager.hitButton.SetActive(true);
        GameManager.stayButton.SetActive(true);
        GameManager.betButton.SetActive(false);
    }
}
