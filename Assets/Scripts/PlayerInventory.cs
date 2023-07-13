using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfBalls { get; private set; }

    public void BallCollected()
    {
        NumberOfBalls++;
    }
}
