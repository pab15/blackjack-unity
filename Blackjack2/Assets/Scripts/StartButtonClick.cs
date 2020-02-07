using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonClick : MonoBehaviour
{
    private GameObject startButton;
    private GameObject deckSprite;
    private GameObject dealButton;

    void Start()
    {
        startButton = GameObject.Find("StartButton");
        deckSprite = GameObject.Find("Deck");
        dealButton = GameObject.Find("DealHand");
        deckSprite.SetActive(false);
        dealButton.SetActive(false);
    }

    public void OnClickStartGame()
    {
        startButton.SetActive(false);
        deckSprite.SetActive(true);
        dealButton.SetActive(true);
    }
}
