﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayP : MonoBehaviour
{
    public void OnClickStay()
    {
        GameManager.playerTurn = false;
    }
}
