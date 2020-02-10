using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetButton : MonoBehaviour
{
    public void OnClickBet()
    {
        GameManager.hasBet = true;
        print(GameManager.playerBet);
    }
}
