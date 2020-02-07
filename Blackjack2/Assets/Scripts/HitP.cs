using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitP : MonoBehaviour
{
    public void OnClickHit()
    {
        DealHandClick.playerHit = true;
        print(DealHandClick.playerHit);
    }
}
