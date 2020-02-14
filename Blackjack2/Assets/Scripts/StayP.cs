using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StayP : MonoBehaviour
{
    public void OnClickStay()
    {
        if (GameManager.hasBet == true)
        {
            GameManager.playerPosition = 2;
            GameManager.playerTurn = false;
            GameManager.DealerTurn();
            GameManager.restartButton.SetActive(true);
            GameManager.betInput.SetActive(false);
            GameManager.hitButton.SetActive(false);
            GameManager.stayButton.SetActive(false);
            GameManager.rageQuitButton.SetActive(false);
        }
    }
}
