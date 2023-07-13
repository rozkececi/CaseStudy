using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour

{
    private TextMeshProUGUI ballText;
    void Start()
    {
        ballText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBallText(PlayerInventory playerInventory)
    {
        ballText.text = playerInventory.NumberOfBalls.ToString(); // playerInventory �zerindeki NumberOfBalls de�erini alarak top say�s�n� g�nceller.
    }
}


