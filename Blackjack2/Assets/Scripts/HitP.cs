using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitP : MonoBehaviour
{
    public void OnClickHit()
    {
        GameManager.playerHit = true;
        print(GameManager.playerHit);
    }
}
