using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RageQuit : MonoBehaviour
{
    public void OnClickRageQuit()
    {
        GameManager.noMoney = true;
        GameManager.RestartGame();
        GameManager.rageQuitButton.SetActive(false);
    }
}
