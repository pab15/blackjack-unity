﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonClick : MonoBehaviour
{
    public void OnClickStartGame()
    {
        GameManager.startButton.SetActive(false);
        GameManager.deckInput.SetActive(false);
        GameManager.deckSprite.SetActive(true);
        GameManager.dealButton.SetActive(true);
        print(GameManager.numDecks);
    }
}
