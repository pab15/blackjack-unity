using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckSelector : MonoBehaviour
{
    public void NumDecks(int index)
    {
            GameManager.numDecks = index;
    }

}

