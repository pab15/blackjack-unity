using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetInput : MonoBehaviour
{
    public static int playerBet;

    public void BetHandler(int index)
    {
        playerBet = index;
    }
}
