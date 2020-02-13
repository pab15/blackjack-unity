using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameClick : MonoBehaviour
{
    public void OnClickNewGame()
    {
        if (GameManager.playerMoney <= 0)
            GameManager.noMoney = true;
        GameManager.RestartGame();
        GameManager.restartButton.SetActive(false);
    }
}
