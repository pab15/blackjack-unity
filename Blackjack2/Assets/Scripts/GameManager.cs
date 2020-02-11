using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite two_club;
    public Sprite three_club;
    public Sprite four_club;
    public Sprite five_club;
    public Sprite six_club;
    public Sprite seven_club;
    public Sprite eight_club;
    public Sprite nine_club;
    public Sprite ten_club;
    public Sprite jack_club;
    public Sprite queen_club;
    public Sprite king_club;
    public Sprite ace_club;

    public Sprite two_diamond;
    public Sprite three_diamond;
    public Sprite four_diamond;
    public Sprite five_diamond;
    public Sprite six_diamond;
    public Sprite seven_diamond;
    public Sprite eight_diamond;
    public Sprite nine_diamond;
    public Sprite ten_diamond;
    public Sprite jack_diamond;
    public Sprite queen_diamond;
    public Sprite king_diamond;
    public Sprite ace_diamond;

    public Sprite two_heart;
    public Sprite three_heart;
    public Sprite four_heart;
    public Sprite five_heart;
    public Sprite six_heart;
    public Sprite seven_heart;
    public Sprite eight_heart;
    public Sprite nine_heart;
    public Sprite ten_heart;
    public Sprite jack_heart;
    public Sprite queen_heart;
    public Sprite king_heart;
    public Sprite ace_heart;

    public Sprite two_spade;
    public Sprite three_spade;
    public Sprite four_spade;
    public Sprite five_spade;
    public Sprite six_spade;
    public Sprite seven_spade;
    public Sprite eight_spade;
    public Sprite nine_spade;
    public Sprite ten_spade;
    public Sprite jack_spade;
    public Sprite queen_spade;
    public Sprite king_spade;
    public Sprite ace_spade;

    public static GameObject startButton;
    public static GameObject deckSprite;
    public static GameObject dealButton;
    public static GameObject hitButton;
    public static GameObject stayButton;
    public static GameObject betButton;
    public static GameObject betInput;
    public static GameObject deckInput;
    public static GameObject cardToCreate;
    public static GameObject playerSpace;
    public static GameObject opponentSpace;
    public GameObject cardObject;

    public static string[] suits = { "C", "D", "H", "S" };
    public static string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    public static int numDecks;
    public static List<string> deck;
    public static List<string> playerHand = new List<string>();
    public static List<string> dealerHand = new List<string>();

    public static int playerBet;
    public static int playerMoney = 200;
    public static int dealerMoney = 200;
    public static int playerHandCount = 0;
    public static int dealerHandCount = 0;

    public static bool playerWin;
    public static bool hasBet = false;
    public static bool tie = false;
    public static bool playerTurn = true;
    public static bool dealerTurn = false;
    public static bool dealerHit = false;
    public static bool playerHit = false;

    public static GameManager gameManager;


    void Start()
    {
        startButton = GameObject.Find("StartButton");
        deckSprite = GameObject.Find("Deck");
        dealButton = GameObject.Find("DealHand");
        hitButton = GameObject.Find("Hit");
        stayButton = GameObject.Find("Stay");
        betButton = GameObject.Find("Bet");
        betInput = GameObject.Find("BetInput");
        deckInput = GameObject.Find("DeckInput");
        cardToCreate = GameObject.Find("Card");
        playerSpace = GameObject.Find("PlayerSpace");
        opponentSpace = GameObject.Find("DealerSpace");

        deckSprite.SetActive(false);
        dealButton.SetActive(false);
        hitButton.SetActive(false);
        stayButton.SetActive(false);
        betButton.SetActive(false);
        betInput.SetActive(false);

        gameManager = this;
    }

    // From: https://www.youtube.com/watch?v=1Cmb181-quI:
    public static List<string> setDeck()
    {
        List<string> result = new List<string>();

        for (int i = 0; i < numDecks; i++)
        {
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    result.Add(suit + value);
                }
            }
        }
        
        return result;
    }

    // From: https://www.youtube.com/watch?v=1Cmb181-quI:
    public static void ShuffleDeck<T>(List<T> list)
    {
        System.Random random = new System.Random();

        int n = list.Count;

        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

    public static void DealCard(ref List<string> handToDeal, GameObject spaceToDeal)
    {
        string cardVal = deck[0];
        handToDeal.Add(deck[0]);
        
        GameObject createdCard = Instantiate(cardToCreate, new Vector3(0, 0, 0), Quaternion.identity);
        createdCard.transform.SetParent(spaceToDeal.transform, false);
        Image imageComponent = createdCard.GetComponent<Image>();

        if (cardVal == "C2")
            imageComponent.sprite = gameManager.two_club;
        if (cardVal == "C3")
            imageComponent.sprite = gameManager.three_club;
        if (cardVal == "C4")
            imageComponent.sprite = gameManager.four_club;
        if (cardVal == "C5")
            imageComponent.sprite = gameManager.five_club;
        if (cardVal == "C6")
            imageComponent.sprite = gameManager.six_club;
        if (cardVal == "C7")
            imageComponent.sprite = gameManager.seven_club;
        if (cardVal == "C8")
            imageComponent.sprite = gameManager.eight_club;
        if (cardVal == "C9")
            imageComponent.sprite = gameManager.nine_club;
        if (cardVal == "C10")
            imageComponent.sprite = gameManager.ten_club;
        if (cardVal == "CJ")
            imageComponent.sprite = gameManager.jack_club;
        if (cardVal == "CQ")
            imageComponent.sprite = gameManager.queen_club;
        if (cardVal == "CK")
            imageComponent.sprite = gameManager.king_club;
        if (cardVal == "CA")
            imageComponent.sprite = gameManager.ace_club;
        if (cardVal == "D2")
            imageComponent.sprite = gameManager.two_diamond;
        if (cardVal == "D3")
            imageComponent.sprite = gameManager.three_diamond;
        if (cardVal == "D4")
            imageComponent.sprite = gameManager.four_diamond;
        if (cardVal == "D5")
            imageComponent.sprite = gameManager.five_diamond;
        if (cardVal == "D6")
            imageComponent.sprite = gameManager.six_diamond;
        if (cardVal == "D7")
            imageComponent.sprite = gameManager.seven_diamond;
        if (cardVal == "D8")
            imageComponent.sprite = gameManager.eight_diamond;
        if (cardVal == "D9")
            imageComponent.sprite = gameManager.nine_diamond;
        if (cardVal == "D10")
            imageComponent.sprite = gameManager.ten_diamond;
        if (cardVal == "DJ")
            imageComponent.sprite = gameManager.jack_diamond;
        if (cardVal == "DQ")
            imageComponent.sprite = gameManager.queen_diamond;
        if (cardVal == "DK")
            imageComponent.sprite = gameManager.king_diamond;
        if (cardVal == "DA")
            imageComponent.sprite = gameManager.ace_diamond;
        if (cardVal == "H2")
            imageComponent.sprite = gameManager.two_heart;
        if (cardVal == "H3")
            imageComponent.sprite = gameManager.three_heart;
        if (cardVal == "H4")
            imageComponent.sprite = gameManager.four_heart;
        if (cardVal == "H5")
            imageComponent.sprite = gameManager.five_heart;
        if (cardVal == "H6")
            imageComponent.sprite = gameManager.six_heart;
        if (cardVal == "H7")
            imageComponent.sprite = gameManager.seven_heart;
        if (cardVal == "H8")
            imageComponent.sprite = gameManager.eight_heart;
        if (cardVal == "H9")
            imageComponent.sprite = gameManager.nine_heart;
        if (cardVal == "H10")
            imageComponent.sprite = gameManager.ten_heart;
        if (cardVal == "HJ")
            imageComponent.sprite = gameManager.jack_heart;
        if (cardVal == "HQ")
            imageComponent.sprite = gameManager.queen_heart;
        if (cardVal == "HK")
            imageComponent.sprite = gameManager.king_heart;
        if (cardVal == "HA")
            imageComponent.sprite = gameManager.ace_heart;
        if (cardVal == "S2")
            imageComponent.sprite = gameManager.two_spade;
        if (cardVal == "S3")
            imageComponent.sprite = gameManager.three_spade;
        if (cardVal == "S4")
            imageComponent.sprite = gameManager.four_spade;
        if (cardVal == "S5")
            imageComponent.sprite = gameManager.five_spade;
        if (cardVal == "S6")
            imageComponent.sprite = gameManager.six_spade;
        if (cardVal == "S7")
            imageComponent.sprite = gameManager.seven_spade;
        if (cardVal == "S8")
            imageComponent.sprite = gameManager.eight_spade;
        if (cardVal == "S9")
            imageComponent.sprite = gameManager.nine_spade;
        if (cardVal == "S10")
            imageComponent.sprite = gameManager.ten_spade;
        if (cardVal == "SJ")
            imageComponent.sprite = gameManager.jack_spade;
        if (cardVal == "SQ")
            imageComponent.sprite = gameManager.queen_spade;
        if (cardVal == "SK")
            imageComponent.sprite = gameManager.king_spade;
        if (cardVal == "SA")
            imageComponent.sprite = gameManager.ace_spade;

        deck.RemoveAt(0);
    }

    public static void PutCardsBack()
    {
        foreach (string card in playerHand)
        {
            deck.Add(card);
        }
        foreach (string card in dealerHand)
        {
            deck.Add(card);
        }
        playerHand.Clear();
        dealerHand.Clear();
    }

    public static void PlayerTurn()
    {
        foreach (string card in playerHand)
        {
            playerHandCount += FetchCardValue(card);
        }
    }

    public static void PlayerHit()
    {
        int position = 2;

        while (playerHit)
        {
            DealCard(ref playerHand, playerSpace);
            playerHandCount += FetchCardValue(playerHand[position]);
            if (playerHandCount > 21)
            {
                playerHit = false;
                playerWin = false;
            }
            position++;
            playerHit = false;
        }
    }

    public static void DealerTurn()
    {
        foreach (string card in dealerHand)
        {
            dealerHandCount += FetchCardValue(card);
        }

        if (dealerHandCount < 17)
        {
            dealerHit = true;
            DealerHit();
        }

        if (playerWin == true)
            playerWin = true;
        else if (dealerHandCount > playerHandCount)
            playerWin = false;
        else if (dealerHandCount < playerHandCount)
            playerWin = true;
        else if (dealerHandCount == playerHandCount)
            tie = true;
    }

    public static void DealerHit()
    {
        int position = 2;
        while (dealerHit == true)
        {
            DealCard(ref dealerHand, opponentSpace);
            dealerHandCount += FetchCardValue(dealerHand[position]);
            if (dealerHandCount > 17 && dealerHandCount <= 21)
                dealerHit = false;
            else if (dealerHandCount > 21)
            {
                dealerHit = false;
                playerWin = true;
            }
            position++;
        }
    }

    public static int FetchCardValue(string card)
    {
        string value = card.Substring(1);

        switch (value)
        {
            case "2":
                return 2;
            case "3":
                return 3;
            case "4":
                return 4;
            case "5":
                return 5;
            case "6":
                return 6;
            case "7":
                return 7;
            case "8":
                return 8;
            case "9":
                return 9;
            case "10":
            case "J":
            case "Q":
            case "K":
                return 10;
            case "A":
                return 11;
            default:
                return 0;
        }
    }
}
