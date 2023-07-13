using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();


        if(playerInventory != null) // E�er tetikleyiciyle �arp��an nesne bir PlayerInventory bile�enine sahipse
        {
            playerInventory.BallCollected(); // PlayerInventory bile�enindeki BallCollected metodunu �a��rarak top toplama i�lemini ger�ekle�tirir.
            gameObject.SetActive(false); // Tetikleyici nesneyi devre d��� b�rak�r.
        }
    }
    }

