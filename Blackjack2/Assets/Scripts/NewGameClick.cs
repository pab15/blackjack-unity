using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameClick : MonoBehaviour
{
    public void OnClickNewGame()
    {
        GameManager.RestartGame();
        GameManager.restartButton.SetActive(false);
    }
}
