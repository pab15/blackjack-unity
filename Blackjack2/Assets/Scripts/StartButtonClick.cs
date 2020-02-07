using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonClick : MonoBehaviour
{
    public GameObject startButton;
    public GameObject deckSprite;
    public GameObject dealButton;
    public GameObject hitButton;
    public GameObject stayButton;
    public GameObject betButton;
    public GameObject betInput;

    void Start()
    {
        startButton = GameObject.Find("StartButton");
        deckSprite = GameObject.Find("Deck");
        dealButton = GameObject.Find("DealHand");
        hitButton = GameObject.Find("Hit");
        stayButton = GameObject.Find("Stay");
        betButton = GameObject.Find("Bet");
        betInput = GameObject.Find("BetInput");

        deckSprite.SetActive(false);
        dealButton.SetActive(false);
        hitButton.SetActive(false);
        stayButton.SetActive(false);
        betButton.SetActive(false);
        betInput.SetActive(false);
    }

    public void OnClickStartGame()
    {
        startButton.SetActive(false);
        deckSprite.SetActive(true);
        dealButton.SetActive(true);
    }
}
