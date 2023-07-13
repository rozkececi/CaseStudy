using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public int requiredBallCount = 10; // Gerekli top say�s�

    private PlayerInventory playerInventory; 
   


    private void Awake()
    {
        playerInventory = FindObjectOfType<PlayerInventory>();
        playerInventory.OnBallCollected.AddListener(CheckBallCount); // OnBallCollected olay�na CheckBallCount metodunu dinleyici olarak ekler.
    }

    private void CheckBallCount(PlayerInventory inventory)
    {
        if (inventory.NumberOfBalls >= requiredBallCount) // Oyuncunun toplad��� top say�s� gereken top say�s�na e�it veya b�y�kse oyun yeniden ba�lat�l�r.
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Oyun sahnesini yeniden y�kler, oyuna ba�tan ba�lar.
    }
}
