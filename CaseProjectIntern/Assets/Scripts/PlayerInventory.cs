using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour

{
    public float gettingSize = 0.1f;
    //karakterin zulas�ndaki top say�s�n� bildiriyor
    public int NumberOfBalls { get; private set; }

    public UnityEvent<PlayerInventory> OnBallCollected;

    public void BallCollected()
    {
        NumberOfBalls++;
        OnBallCollected.Invoke(this); // Top topland���nda OnBallCollected olay�n� tetikler ve bu PlayerInventory �rne�ini iletir
        Vector3 newSize = transform.localScale + new Vector3(gettingSize, gettingSize, gettingSize); // Karakterin �l�e�ini b�y�t�r
        transform.localScale = newSize;
    }

}
