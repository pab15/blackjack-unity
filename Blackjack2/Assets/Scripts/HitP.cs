using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitP : MonoBehaviour
{
    public void OnClickHit()
    {
        if (GameManager.hasBet == true)
        {
            GameManager.playerHit = true;
            GameManager.PlayerHit();
        }
    }
}
