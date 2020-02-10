using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardChanger : MonoBehaviour
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

    public static Image imageComponent;

    void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    public static void SetCardImage(string cardVal)
    {
        if (cardVal == "C2")
            imageComponent.sprite = two_club;
        if (cardVal == "C3")
            imageComponent.sprite = three_club;
        if (cardVal == "C4")
            imageComponent.sprite = four_club;
        if (cardVal == "C5")
            imageComponent.sprite = five_club;
        if (cardVal == "C6")
            imageComponent.sprite = six_club;
        if (cardVal == "C7")
            imageComponent.sprite = seven_club;
        if (cardVal == "C8")
            imageComponent.sprite = eight_club;
        if (cardVal == "C9")
            imageComponent.sprite = nine_club;
        if (cardVal == "C10")
            imageComponent.sprite = ten_club;
        if (cardVal == "CJ")
            imageComponent.sprite = jack_club;
        if (cardVal == "CQ")
            imageComponent.sprite = queen_club;
        if (cardVal == "CK")
            imageComponent.sprite = king_club;
        if (cardVal == "CA")
            imageComponent.sprite = ace_club;
        if (cardVal == "D2")
            imageComponent.sprite = two_diamond;
        if (cardVal == "D3")
            imageComponent.sprite = three_diamond;
        if (cardVal == "D4")
            imageComponent.sprite = four_diamond;
        if (cardVal == "D5")
            imageComponent.sprite = five_diamond;
        if (cardVal == "D6")
            imageComponent.sprite = six_diamond;
        if (cardVal == "D7")
            imageComponent.sprite = seven_diamond;
        if (cardVal == "D8")
            imageComponent.sprite = eight_diamond;
        if (cardVal == "D9")
            imageComponent.sprite = nine_diamond;
        if (cardVal == "D10")
            imageComponent.sprite = ten_diamond;
        if (cardVal == "DJ")
            imageComponent.sprite = jack_diamond;
        if (cardVal == "DQ")
            imageComponent.sprite = queen_diamond;
        if (cardVal == "DK")
            imageComponent.sprite = king_diamond;
        if (cardVal == "DA")
            imageComponent.sprite = ace_diamond;
        if (cardVal == "H2")
            imageComponent.sprite = two_heart;
        if (cardVal == "H3")
            imageComponent.sprite = three_heart;
        if (cardVal == "H4")
            imageComponent.sprite = four_heart;
        if (cardVal == "H5")
            imageComponent.sprite = five_heart;
        if (cardVal == "H6")
            imageComponent.sprite = six_heart;
        if (cardVal == "H7")
            imageComponent.sprite = seven_heart;
        if (cardVal == "H8")
            imageComponent.sprite = eight_heart;
        if (cardVal == "H9")
            imageComponent.sprite = nine_heart;
        if (cardVal == "H10")
            imageComponent.sprite = ten_heart;
        if (cardVal == "HJ")
            imageComponent.sprite = jack_heart;
        if (cardVal == "HQ")
            imageComponent.sprite = queen_heart;
        if (cardVal == "HK")
            imageComponent.sprite = king_heart;
        if (cardVal == "HA")
            imageComponent.sprite = ace_heart;
        if (cardVal == "S2")
            imageComponent.sprite = two_spade;
        if (cardVal == "S3")
            imageComponent.sprite = three_spade;
        if (cardVal == "S4")
            imageComponent.sprite = four_spade;
        if (cardVal == "S5")
            imageComponent.sprite = five_spade;
        if (cardVal == "S6")
            imageComponent.sprite = six_spade;
        if (cardVal == "S7")
            imageComponent.sprite = seven_spade;
        if (cardVal == "S8")
            imageComponent.sprite = eight_spade;
        if (cardVal == "S9")
            imageComponent.sprite = nine_spade;
        if (cardVal == "S10")
            imageComponent.sprite = ten_spade;
        if (cardVal == "SJ")
            imageComponent.sprite = jack_spade;
        if (cardVal == "SQ")
            imageComponent.sprite = queen_spade;
        if (cardVal == "SK")
            imageComponent.sprite = king_spade;
        if (cardVal == "SA")
            imageComponent.sprite = ace_spade;
    }

    public static void SetInGameManager(string value)
    {
        SetCardImage(value);
    }
}
